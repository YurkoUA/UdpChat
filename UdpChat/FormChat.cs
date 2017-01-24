using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace UdpChat
{
    public partial class FormChat : Form
    {
        private readonly IPAddress multicastAddress;
        private readonly IPAddress localAddress;
        private readonly int localPort;
        private readonly int remotePort;
        private readonly string userName;

        public FormChat(IPAddress multicastAddress, IPAddress localAddress, int localPort, int remotePort, string name)
        {
            InitializeComponent();
            Text += $" - {localAddress} - {name}";

            this.multicastAddress = multicastAddress;
            this.localAddress = localAddress;
            this.localPort = localPort;
            this.remotePort = remotePort;
            this.userName = name;

            var receiveThread = new Thread(ReceiveMessage);
            receiveThread.Start();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(messageText.Text))
                return;

            var senderClient = new UdpClient();
            var endPoint = new IPEndPoint(multicastAddress, remotePort);

            try
            {
                var message = $"{userName} [{localAddress}]: {messageText.Text}";
                byte[] data = Encoding.Unicode.GetBytes(message);
                senderClient.Send(data, data.Length, endPoint);

                messageText.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                senderClient.Close();
            }
        }

        private void ReceiveMessage()
        {
            var receiver = new UdpClient(localPort);
            receiver.JoinMulticastGroup(multicastAddress, 20);
            IPEndPoint remoteIP = null;

            try
            {
                while (true)
                {
                    byte[] data = receiver.Receive(ref remoteIP);

                    if (!remoteIP.Address.Equals(localAddress))
                    {
                        var message = Encoding.Unicode.GetString(data);

                        Invoke(new MethodInvoker(() =>
                        {
                            chatTextBox.AppendText($"[{DateTime.Now.ToLongTimeString()}] - {message}\n");
                            chatTextBox.ScrollToCaret();
                        }));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                receiver.Close();
            }
        }

        private void messageText_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                sendButton_Click(sendButton, null);
        }
    }
}
