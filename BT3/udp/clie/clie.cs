using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace clie
{
    public partial class Cli : Form
    {
        public Cli()
        {
            InitializeComponent();
        }

        private void Ser_Load(object sender, EventArgs e)
        {

        }
        private Socket client;
        private void senddt()
        {
            using (client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp))
            {
                int por;
                if(int.TryParse(porttxt.Text.Trim(), out por))
                {
                    byte[] data = Encoding.UTF8.GetBytes(messtxt.Text);
                    IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IpAdr.Text.Trim()), por);
                    client.SendTo(data, ep);
                    messtxt.Text = "";

                    byte[] receiveBuffer = new byte[1024];
                    EndPoint serverResponseEndPoint = new IPEndPoint(IPAddress.Any, 0);
                    int receivedBytes = client.ReceiveFrom(receiveBuffer, ref serverResponseEndPoint);
                    string serverResponse = Encoding.UTF8.GetString(receiveBuffer, 0, receivedBytes);
                    receivetxt.Text += "Receive from server: " + serverResponseEndPoint.ToString() + "  " + serverResponse + '\n';
                }
                else
                {
                    MessageBox.Show("Please enter correct port");
                }
                
            }

        }
        private void sendbtn_Click(object sender, EventArgs e)
        {
            Thread sendthread = new Thread(senddt);
            sendthread.Start();
        }

        private void messtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void messtxt_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            IpAdr.Text = "";
            porttxt.Text = "";
            messtxt.Text = "";
            receivetxt.Text = "";
            if(client == null)
            {
                this.Close();
            }
            else
            {
                client.Close();
            }
            
        }
    }
}
