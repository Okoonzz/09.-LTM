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
    public partial class Form4 : Form
    {
        public int a;
        public Form4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private bool chk()
        {
            if(conv.Text == "" || to2.Text == "")
            {
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chk())
            {
                if(conv.Text == "Decimal")
                {
                    try
                    {
                        a = int.Parse(num1.Text.Trim());
                    }
                    catch
                    {
                        MessageBox.Show("Please enter correct dec number!!!");
                        res.Text = "";
                        return;
                    }
                    if (to2.Text == "Hexa")
                    {
                        res.Text = a.ToString("X");
                    }
                    else if (to2.Text == "Binary")
                    {
                        string result = Convert.ToString(a, 2);
                        res.Text = result;
                    }
                    else
                    {
                        res.Text += a.ToString();
                    }
                }
                else if(conv.Text == "Binary")
                {
                    foreach(char c in num1.Text.Trim())
                    {
                        if (c != '1' && c != '0')
                        {
                            MessageBox.Show("Please enter bin number!!!");
                            res.Text = "";
                            return;
                        }
                    }
                    if(to2.Text == "Decimal")
                    {
                        try
                        {
                            a = Convert.ToInt32(num1.Text.Trim(), 2);
                            res.Text = a.ToString();
                        }
                        catch
                        {
                            MessageBox.Show("Only integer 32bits");
                            res.Text = "";
                        }
                        
                    }
                    else if(to2.Text == "Hexa")
                    {
                        try
                        {
                            a = Convert.ToInt32(num1.Text.Trim(), 2);
                            res.Text = a.ToString("X");
                        }
                        catch
                        {
                            MessageBox.Show("Only integer 32bits");
                            res.Text = "";
                        }
                        
                    }
                    else
                    {
                        res.Text = num1.Text.Trim();
                    }
                }
                else
                {
                    foreach (char c in num1.Text.Trim())
                    {
                        if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f')))
                        {
                            MessageBox.Show("Please enter a correct hexadecimal number");
                            res.Text = "";
                            return;
                        }
                    }
                    if (to2.Text == "Decimal")
                    {
                        try
                        {
                            a = Convert.ToInt32(num1.Text.Trim(), 16);
                            res.Text = a.ToString();
                        }
                        catch
                        {
                            MessageBox.Show("Only integer 32bits");
                            res.Text = "";
                        }
                        
                    }
                    else if(to2.Text == "Binary")
                    {
                        string result = "";
                        try
                        {
                            result = Convert.ToString(Convert.ToInt32(num1.Text.Trim(), 16),2);
                            res.Text = result;
                        }
                        catch
                        {
                            MessageBox.Show("Only integer 32bits");
                            res.Text = "";
                        }
                        
                    }
                    else
                    {
                        res.Text = num1.Text.Trim();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select conversion type");
                res.Text = "";
            }

            
        }

        private void ex_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void del_Click(object sender, EventArgs e)
        {
            num1.Text = "";
            res.Text = "";
            conv.Text = "";
            to2.Text = "";
        }
    }
}
