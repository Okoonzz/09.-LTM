using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace lab3
{
    public partial class Bai3_client : Form
    {

        public Bai3_client()
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


        private TcpClient tcpClient;
        private int cnt = 0;


        private async Task ReceiveDataAsync()
        {
            NetworkStream stream = tcpClient.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead;

            while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                string receivedData = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                txtContentClientSent.Text += receivedData + '\n';
            }
        }


        private void CheckConnect()
        {
            try
            {
                tcpClient = new TcpClient();
                tcpClient.Connect(txtIpClient.Text.Trim(), Int32.Parse(txtPortClient.Text.Trim()));
                txtContentClientSent.Text += "Connected Successful\n";
                cnt++;
            }
            catch (Exception)
            {
                MessageBox.Show($"Port {txtPortClient.Text.Trim()} on {txtIpClient.Text.Trim()} is closed or not reachable.");
                return;
            }
        }

        private void Connected()
        {
            NetworkStream stream = tcpClient.GetStream();

            string textData = txtContentClientPre.Text.Trim() + '\n';
            Byte[] data = Encoding.UTF8.GetBytes(textData);
            stream.Write(data, 0, data.Length);
            _ = ReceiveDataAsync();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {   
            if(cnt < 1)
            {
                CheckConnect();
            }
            else return;
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(cnt == 0)
            {
                MessageBox.Show("Please connect in advance");
                return;
            }
            Connected();
            txtContentClientPre.Text = "";
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                tcpClient.GetStream().Close();
                tcpClient.Close();
                MessageBox.Show("Disconnect successfully");
                cnt = 0;
                txtContentClientSent.Text = "";
            }
            catch
            {
                return;
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
