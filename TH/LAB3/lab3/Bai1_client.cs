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

namespace lab3
{
    public partial class Bai1_client : Form
    {
        public Bai1_client()
        {
            InitializeComponent();
        }

        private void Bai1_client_Load(object sender, EventArgs e)
        {

        }

        private void IPtxt_TextChanged(object sender, EventArgs e)
        {

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


        private void sendbtn_Click(object sender, EventArgs e)
        {
            int port;
            if (int.TryParse(Porttxt.Text.Trim(), out port))
            {
                UdpClient udpClient = new UdpClient();
                Byte[] senddata = Encoding.UTF8.GetBytes(messtxt.Text);
                try
                {
                    udpClient.Send(senddata, senddata.Length, IPtxt.Text, port);
                    messtxt.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error sending data: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter correct port");
            }
        }

    }
}
