using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
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

        private Thread receiveThread;

        public FormChat(IPAddress multicastAddress, IPAddress localAddress, int localPort, int remotePort, string name)
        {
            InitializeComponent();
            Text += $" - {localAddress} - {name}";

            this.multicastAddress = multicastAddress;
            this.localAddress = localAddress;
            this.localPort = localPort;
            this.remotePort = remotePort;
            this.userName = name;

            receiveThread = new Thread(ReceiveMessage);
            receiveThread.Start();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(messageText.Text))
            {
                SendMessage(messageText.Text);
                messageText.Clear();
            }
        }

        private void SendMessage(string text)
        {
            var senderClient = new UdpClient();
            var endPoint = new IPEndPoint(multicastAddress, remotePort);

            try
            {
                var message = new Message
                {
                    UserName = userName,
                    UserIP = localAddress.ToString(),
                    Text = text
                };

                byte[] data = message.Serialize();
                senderClient.Send(data, data.Length, endPoint);
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
                    var message = Message.Deserialize(data);

                    var append = $"[{DateTime.Now.ToLongTimeString()}] - {message.UserName} [{message.UserIP}]: {message.Text}";
                    Color color = remoteIP.Address.Equals(localAddress) ? Color.Blue : Color.Black;

                    appendLine(append, color);
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

        private void appendLine(string text, Color color)
        {
            Invoke(new MethodInvoker(() =>
            {
                chatTextBox.SelectionStart = chatTextBox.TextLength;
                chatTextBox.SelectionLength = 0;
                chatTextBox.SelectionColor = color;
                chatTextBox.AppendText($"{text}\n");
                chatTextBox.SelectionColor = chatTextBox.ForeColor;
                chatTextBox.ScrollToCaret();
            }));
        }

        private void FormChat_FormClosed(object sender, FormClosedEventArgs e)
        {
            receiveThread.Abort();
        }
    }
}
