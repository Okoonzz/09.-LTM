using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcul
{
    public partial class Form3 : Form
    {
        public int a;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1.Text = "";
            num2.Text = "";
        }

        private void Ex_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool chk()
        {
            if(num1.Text.Trim() == "")
            {
                return false;
            }
            return true;
        }

        private void Read_Click(object sender, EventArgs e)
        {
            if(!chk())
            {
                MessageBox.Show("Please enter integer number");
                return;
            }
            try
            {
                a = int.Parse(num1.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Please eneter correct integer number");
                return;
            }
            switch (a)
            {
                case 0:
                    num2.Text = "Không";
                    break;
                case 1:
                    num2.Text = "Một";
                    break;
                case 2:
                    num2.Text = "Hai";
                    break;
                case 3:
                    num2.Text = "Ba";
                    break;
                case 4:
                    num2.Text = "Bốn";
                    break;
                case 5:
                    num2.Text = "Năm";
                    break;
                case 6:
                    num2.Text = "Sáu";
                    break;
                case 7:
                    num2.Text = "Bảy";
                    break;
                case 8:
                    num2.Text = "Tám";
                    break;
                case 9:
                    num2.Text = "Chín";
                    break;
                default:
                    MessageBox.Show("Number must 0 - 9");
                    num2.Text = "";
                    return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
