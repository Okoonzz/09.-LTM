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

namespace Server
{
    public partial class FormServer : Form
    {
        public FormServer()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private List<Socket> clientSockets = new List<Socket>();


        private void txtContentPress(object sender, KeyPressEventArgs e)
        {
                e.Handled = true;
        }

        Socket listener;
        private bool isClosing = false;
        Thread servertr;
        private void _server()
        {
            try
            {
                listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ipepserver = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888);
                listener.Bind(ipepserver);
                listener.Listen(-1);
                txtContentServer.Text += "Telnet running on 127.0.0.1 8888\n";

                while (true)
                {
                    Socket clientsocket = listener.Accept();
                    IPEndPoint clientEndPoint = clientsocket.RemoteEndPoint as IPEndPoint;
                    txtContentServer.Text += $"New client connected from: {clientEndPoint.Address}: {clientEndPoint.Port}\n";
                    clientSockets.Add(clientsocket);
                    Thread clientThread = new Thread(() => HandleClient(clientsocket, clientEndPoint));
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

        private void HandleClient(Socket clientsocket, IPEndPoint clientEp)
        {
            int bytereceive = 0;
            byte[] recv = new byte[1];

            while (true)
            {
                string text = "";
                do
                {
                    bytereceive = clientsocket.Receive(recv);
                    if (bytereceive == 0)
                    {
                        clientsocket.Close();
                        txtContentServer.Text += $"{clientEp.Address}: {clientEp.Port} Disconnected\n";
                        clientSockets.Remove(clientsocket);
                        return;
                    }
                    text += Encoding.UTF8.GetString(recv);
                } while (text[text.Length - 1] != '\n');

                txtContentServer.Text += $"{clientEp.Address}: {clientEp.Port} {text}\n";
                byte[] data = Encoding.UTF8.GetBytes(text);
                foreach (var client in clientSockets)
                {
                    client.Send(data);
                }
            }
        }



        private void btnListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            servertr = new Thread(_server);
            servertr.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
