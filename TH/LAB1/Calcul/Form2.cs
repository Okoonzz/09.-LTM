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
    public partial class Form2 : Form
    {
        public double a1, a2, a3;
        public Form2()
        {
            InitializeComponent();
        }

        private bool chk()
        {
            if(num1.Text.Trim() == "" || num2.Text.Trim() == "" || num3.Text.Trim() == "")
            {
                return false;
            }
            return true;
        }
        private double _max(double a1, double a2, double a3)
        {
            if (a1 >= a2 && a1 >= a3)
            {
                return a1;
            }
            else if (a2 >= a3 && a2 >= a1)
            {
                return a2;
            }
            else
            {
                return a3;
            }
        }

        private double _min(double a1, double a2, double a3)
        {
            if (a1 <= a2 && a1 <= a3)
            {
                return a1;
            }
            else if (a2 <= a3 && a2 <= a1)
            {
                return a2;
            }
            else
            {
                return a3;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!chk())
            {
                MessageBox.Show("Please enter number!!!");
                return;
            }
            else
            {
                try
                {
                    a1 = double.Parse(num1.Text.Trim());
                    a2 = double.Parse(num2.Text.Trim());
                    a3 = double.Parse(num3.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("Please enter correct number!!!");
                    return;
                }
                maxx.Text = _max(a1, a2, a3).ToString();
                minn.Text = _min(a1, a2, a3).ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            num1.Text = "";
            num2.Text = "";
            num3.Text = "";
            maxx.Text = "";
            minn.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
