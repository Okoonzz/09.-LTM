using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            CheckConnect();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void FormClient_Load(object sender, EventArgs e)
        {

        }


        private TcpClient tcpClient = new TcpClient();


        private void txtContentPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private async Task ReceiveDataAsync()
        {
            NetworkStream stream = tcpClient.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead;

            while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                string receivedData = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                txtContentChat.Text += receivedData + '\n';
            }
        }


        private void CheckConnect()
        {
            try
            {
                tcpClient.Connect("127.0.0.1", 8888);
                MessageBox.Show("Connect Successful");
                _ = ReceiveDataAsync();
            }
            catch (Exception)
            {
                MessageBox.Show($"Port 8888 on 127.0.0.1 is closed or not reachable.");
                this.Close();
            }
        }

        private void Connected()
        {
            NetworkStream stream = tcpClient.GetStream();

            string textData = txtName.Text.Trim()+ ":  " + txtContentSend.Text.Trim() + '\n';
            Byte[] data = Encoding.UTF8.GetBytes(textData);
            stream.Write(data, 0, data.Length);
            txtContentSend.Text = "";
            
        }
        private string userName = null;

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (userName == null && txtName.Text.Trim() != "")
            {
                userName = txtName.Text.Trim();
            }

            if (txtName.Text.Trim() == "" || txtName.Text.Trim() != userName)
            {
                MessageBox.Show("Please enter your name and keep it consistent");
                return;
            }
            else
            {
                Connected();
            }
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
                try
                {
                        tcpClient.GetStream().Close();
                        tcpClient.Close();
                        return;
                }
                catch
                {
                    return;
                }

            }
        }
    }
}
