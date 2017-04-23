using System;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace UdpChat
{
    public partial class FormLogin : Form
    {
        private static IPAddress localIP;

        public FormLogin()
        {
            InitializeComponent();

            checkNetTimer_Tick(null, null);
            checkNetTimer.Start();
            nameText.Text = Dns.GetHostName();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                int remotePort, localPort;
                IPAddress multicastAddress;

                if (string.IsNullOrEmpty(nameText.Text) || string.IsNullOrEmpty(multicastText.Text) ||
                    string.IsNullOrEmpty(localIpText.Text) || string.IsNullOrEmpty(remotePortText.Text))
                {
                    throw new Exception("All fields are required!");
                }

                if (nameText.Text.Length > 32 || nameText.Text.Length < 3)
                {
                    throw new Exception("The \"Name\" length should be between 3 and 32 characters!");
                }


                if (!int.TryParse(remotePortText.Text, out remotePort) || !int.TryParse(localPortText.Text, out localPort))
                {
                    throw new Exception("\"Local port\" and \"Remote port\" should be numbers!");
                }

                if (remotePort < 1 || remotePort > 65535 || localPort < 1 || localPort > 65535)
                {
                    throw new Exception("The \"Local port\" and \"Remote port\" should be between 1 and 65535!");
                }

                if (!IPAddress.TryParse(multicastText.Text, out multicastAddress))
                {
                    throw new Exception("The \"Multicast address\" does not meet the prescribed format!");
                }

                new FormChat(multicastAddress, GetLocalIP(), localPort, remotePort, nameText.Text) { Owner = this }.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkNetTimer_Tick(object sender, EventArgs e)
        {
            localIP = GetLocalIP();
            localIpText.Text = localIP.ToString() ?? "[Network did not match]";

            loginButton.Enabled = localIP != null;
        }

        private IPAddress GetLocalIP()
        {
            var addresses = Dns.GetHostAddresses(Dns.GetHostName()).Where(addr => addr.AddressFamily == AddressFamily.InterNetwork);

            if (addresses.Count() == 0)
            {
                return null;
            }
            return addresses.First();
        }
    }
}
