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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void _clear()
        {
            content.Text = "";
        }

        private void rd_Click(object sender, EventArgs e)
        {
            _clear();
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Select File";
                ofd.Filter = "Text File (*.txt)|*.txt";
                ofd.ShowDialog();
                try
                {
                    StreamReader sr = new StreamReader(ofd.FileName);
                    string _content = sr.ReadToEnd();
                    content.Text = _content;
                    sr.Close();
                    return;
                }
                catch
                {
                    MessageBox.Show($"Can not read file {ofd.FileName}");
                    return;
                }

            }
            catch
            {
                MessageBox.Show("Can not open.");
                return;
            }

        }

        private void wr_Click(object sender, EventArgs e)
        {
            try
            {
                if (content.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter content.");
                    return;
                }
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Select File";
                sfd.Filter = "Text File (*.txt)|*.txt";
                sfd.ShowDialog();
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);

                byte[] buffer = Encoding.UTF8.GetBytes(content.Text.ToUpper().Trim());
                try
                {
                    fs.Write(buffer, 0, buffer.Length);
                    _clear();
                    fs.Close();
                    MessageBox.Show($"Done write to {sfd.FileName}");
                    return;
                }
                catch
                {
                    MessageBox.Show($"Can not save to file {sfd.FileName}");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Can not open.");
                return;
            }
            
        }

        private void Bai1_Load(object sender, EventArgs e)
        {

        }
    }
}
