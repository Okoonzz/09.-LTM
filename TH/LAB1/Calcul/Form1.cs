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
    public partial class Form1 : Form
    {
        public int a, b;
        public Form1()
        {
            InitializeComponent();
            a = 0;
            b = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool chk()
        {
            if (num1.Text.Trim() == "" || num2.Text.Trim() == "")
            {
                return false;
            }
            return true;
        }

        private void sub_Click(object sender, EventArgs e)
        {
            if (!chk())
            {
                MessageBox.Show("Please enter integer number!!!");
            }
            else
            {
                try
                {
                    a = int.Parse(num1.Text.Trim());
                    b = int.Parse(num2.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("Please enter correct integer number");
                    return;
                }
                long result = (long)a - (long)b;
                res.Text = result.ToString();
            }
        }

        private void mul_Click(object sender, EventArgs e)
        {
            if (!chk())
            {
                MessageBox.Show("Please enter integer number!!!");
            }
            else
            {
                try
                {
                    a = int.Parse(num1.Text.Trim());
                    b = int.Parse(num2.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("Please enter correct integer number");
                    return;
                }
                long result = (long)a * (long)b;
                res.Text = result.ToString();
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            num1.Text = "";
            num2.Text = "";
            res.Text = "";
        }

        private void div_Click(object sender, EventArgs e)
        {
            int a1, a2;
            double result;
            if (!chk())
            {
                MessageBox.Show("Please enter integer number!!!");
            }
            else
            {
                try
                {
                    a1 = int.Parse(num1.Text.Trim());
                    a2 = int.Parse(num2.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("Please enter correct integer number");
                    return ;
                }
                if (a2 != 0)
                {
                    result = (double)a1/(double)a2;
                    res.Text= result.ToString();
                }
                else
                {
                    MessageBox.Show("Can not div with 0");
                }

            }
        }

        private void ex_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if(!chk())
            {
                MessageBox.Show("Please enter integer number!!!");
            }
            else
            {
                try
                {
                    a = int.Parse(num1.Text.Trim());
                    b = int.Parse(num2.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("Please enter correct integer number");
                    return;
                }
                long result = (long)a + (long)b;
                res.Text = result.ToString();
            }

        }
    }
}
