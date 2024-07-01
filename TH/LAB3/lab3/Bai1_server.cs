using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Bai1_server : Form
    {
        public Bai1_server()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void txtPortPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private UdpClient server;
        private Thread serverThread;
        private bool isClosing = false;

        private void _server()
        {
            int port;
            if(int.TryParse(porttxt.Text.Trim(), out port))
            {
                try
                {
                    server = new UdpClient(port);
                    while (true)
                    {
                        IPEndPoint remoteEndpoint = new IPEndPoint(IPAddress.Any, 0);
                        Byte[] receivedmess = server.Receive(ref remoteEndpoint);
                        string mess = Encoding.UTF8.GetString(receivedmess);
                        receivedmesstxt.Text += remoteEndpoint.Address.ToString() + ": "+ mess + '\n';
                    }
                }
                catch
                {
                    if (!isClosing)
                    {
                        MessageBox.Show($"Port {port} was opened");
                        return;
                    }
                    
                    return;
                }

            }
            else
            {
                MessageBox.Show("Please enter correct port");
                return;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serverThread = new Thread(_server);
            serverThread.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                isClosing = true;
                server?.Close();
                serverThread?.Abort();
                return;
            }
        }

    }
}
