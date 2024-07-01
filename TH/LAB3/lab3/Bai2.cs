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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        Thread servertr;
        Socket listener;
        private bool isClosing = false;

        private void _server()
        {
            try
            {
                listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ipepserver = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
                listener.Bind(ipepserver);
                listener.Listen(-1);
                servertxt.Text += "Telnet running on 127.0.0.1 8080 \n";

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
                        servertxt.Text += $"{clientEndPoint.Address}: {clientEndPoint.Port} Disconnected\n";
                        return;
                    }
                    text += Encoding.UTF8.GetString(recv);
                } while (text[text.Length - 1] != '\n');

                servertxt.Text += "Received from client: " + text + '\n';
            }
        }


        private void listenbtn_Click(object sender, EventArgs e)
        {
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
                listener ?.Close();
                servertr?.Abort();
                return;
            }
        }
    }
}
