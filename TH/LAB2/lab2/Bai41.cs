using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Bai41 : Form
    {
        public Bai41()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            _Name.Text = "";
            Mssv.Text = "";
            Phone.Text = "";
            Math.Text = "";
            Lit.Text = "";
        }
        public FileStream fs = new FileStream("input.txt", FileMode.Create);

        private bool CheckPhone(string phone)
        {
            if(phone == "")
            {
                MessageBox.Show("Enter your phone");
                return false;
            }
            if(phone[0] != '0')
            {
                MessageBox.Show("Enter correct format phone number");
                return false;
            }
            if(phone.Length != 10)
            {
                MessageBox.Show("Phone must have 10 numbers");
                return false;
            }
            foreach(char c in phone)
            {
                if(!(c >= '0' && c <= '9'))
                {
                    MessageBox.Show("Phone only have number");
                    return false;
                }
            }
            return true;
        }

        private bool CheckPoint(string math, string lit)
        {
            if(math == "" || lit == "")
            {
                MessageBox.Show("Enter your points");
                return false;
            }

            double tmpMath = 0;
            double tmpLit = 0;

            if(!(double.TryParse(math, out tmpMath) && double.TryParse(lit, out tmpLit)))
            {
                MessageBox.Show("Enter correct point");
                return false;   
            }
            if((tmpMath > 10) || (tmpLit > 10) || (tmpMath < 0) || (tmpLit < 0))
            {
                MessageBox.Show("Points must in range 0 - 10");
                return false;
            }
            return true;
        }
        private void Enter_Click(object sender, EventArgs e)
        {
            string contentPhone = Phone.Text.Trim();
            string contentMath = Math.Text.Trim();
            string contentLit = Lit.Text.Trim();

            if(CheckPhone(contentPhone) == false) return;
            if(CheckPoint(contentMath, contentLit) == false) return;

            string content = Mssv.Text.Trim() + ";" + _Name.Text.Trim() + ";" + contentPhone +  ";" + contentMath + ";" + contentLit + '\n';
            byte[] buffer = Encoding.UTF8.GetBytes(content);
            Clear();
            fs.Write(buffer, 0, buffer.Length);
        }

        private void Done_Click(object sender, EventArgs e)
        {
            fs.Close();
            this.Close();
        }
    }
}
