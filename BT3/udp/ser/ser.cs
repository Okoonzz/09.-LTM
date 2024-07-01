using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ser
{
    public partial class ser : Form
    {
        public ser()
        {
            InitializeComponent();
        }
        public Socket s;
        public EndPoint sd;
        public int clientPort;
        public string clientIP;

        private void ser_Load(object sender, EventArgs e)
        {

        }
        private void _server()
        {
            int por;
                
            if(int.TryParse(porttxt.Text, out por))
            {
                s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                IPEndPoint ep = new IPEndPoint(IPAddress.Any, por);
                s.Bind(ep);
                byte[] data = new byte[1024];
                while (true)
                {
                    IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
                    sd = (EndPoint)sender;

                    int lenrecv = s.ReceiveFrom(data, ref sd);
                    string mess = Encoding.UTF8.GetString(data, 0, lenrecv);
                    receivetxt.Text += "Receive from: " + sd.ToString() + " " + mess + '\n';
                    clientPort = ((IPEndPoint)sd).Port;
                    clientIP = ((IPEndPoint)sd).Address.ToString();
                }
            }
            else
            {
                MessageBox.Show("Please enter correct port!!!!");
            }

        }
        private void sendserver()
        {
            
            string sensv = sendtxt.Text;
            byte[] sendata = Encoding.UTF8.GetBytes(sensv);
            s.SendTo(sendata, new IPEndPoint(IPAddress.Parse(clientIP), clientPort));
            sendtxt.Text = "";
        }
        private void listenbtn_Click(object sender, EventArgs e)
        {
            Thread server = new Thread(_server);
            server.Start();
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            Thread senddt = new Thread(sendserver);
            senddt.Start();
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            porttxt.Text = "";
            receivetxt.Text = "";
            if(s == null)
            {
                this.Close();
            }
            else
            {
                s.Close();
            }
            
        }
    }
}
