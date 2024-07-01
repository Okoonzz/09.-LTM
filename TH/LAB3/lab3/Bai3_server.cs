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

namespace lab3
{
    public partial class Bai3_server : Form
    {
        public Bai3_server()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void txtIpPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                int count = 0;
                foreach (char c in (sender as TextBox).Text)
                {
                    if (c == '.')
                    {
                        count++;
                    }
                }
                if (count >= 3)
                    e.Handled = true;
            }
        }

        private void txtPortPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        Socket listener;
        private bool isClosing = false;
        Thread servertr;
        private void _server()
        {
            try
            {
                listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ipepserver = new IPEndPoint(IPAddress.Parse(txtIpServer.Text.Trim()), Int32.Parse(txtPortServer.Text.Trim()));
                listener.Bind(ipepserver);
                listener.Listen(-1);
                txtContent.Text += $"Telnet running on {txtIpServer.Text.Trim()} {txtPortServer.Text.Trim()} \n";

                while (true)
                {
                    Socket clientsocket = listener.Accept();
                    Thread clientThread = new Thread(() => HandleClient(clientsocket));
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                if (!isClosing)
                {
                    MessageBox.Show($"{ex.Message}");
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        private void HandleClient(Socket clientsocket)
        {
            int bytereceive = 0;
            byte[] recv = new byte[1];
            IPEndPoint clientEndPoint = clientsocket.RemoteEndPoint as IPEndPoint;

            while (true)
            {
                string text = "";
                do
                {
                    bytereceive = clientsocket.Receive(recv);
                    if (bytereceive == 0)
                    {
                        clientsocket.Close();
                        txtContent.Text += $"{clientEndPoint.Address}: {clientEndPoint.Port} Disconnected\n";
                        return;
                    }
                    text += Encoding.UTF8.GetString(recv);
                } while (text[text.Length - 1] != '\n');

                txtContent.Text += "Received from client: " + text + '\n';
                byte[] data = Encoding.UTF8.GetBytes(text);
                clientsocket.Send(data);
            }
        }


        private bool Check()
        {
            if (txtPortServer.Text.Trim() == "" || txtPortServer.Text.Trim() == "")
            {
                return false;
            }
            return true;
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            if(Check() == false)
            {
                MessageBox.Show("Please enter IP/Port");
                return;
            }
            CheckForIllegalCrossThreadCalls = false;
            servertr = new Thread(_server);
            servertr.Start();
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
                listener?.Close();
                servertr?.Abort();
                return;
            }
        }

        private void txtPortServer_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtIpServer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
