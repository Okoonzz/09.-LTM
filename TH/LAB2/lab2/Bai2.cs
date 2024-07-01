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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }
        private void _readline(object filename)
        {
            int cnt = 0;
            string _filename = (string)filename;
            try
            {
                using(StreamReader sr = new StreamReader(_filename))
                {
                    while(sr.ReadLine() != null)
                    {
                        cnt++;
                    }
                    line.Text = cnt.ToString();
                }
            }
            catch
            {
                MessageBox.Show($"Can not Read file {_filename}");
                return;
            }

        }
        private void _appearContentWordChar(string tmp)
        {
            string[] words = tmp.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int cntword = words.Length;
            word.Text = cntword.ToString();
            content.Text = tmp;
            character.Text = tmp.Replace("\n", "").Length.ToString();
        }
        private void _clear()
        {
            content.Clear();
            name.Clear();
            path.Clear();
            line.Clear();
            word.Clear();
            character.Clear();
        }
        private void readfile_Click(object sender, EventArgs e)
        {
            _clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select file";
            ofd.Filter = "Text File (*.txt)|*.txt";
            ofd.ShowDialog();

            path.Text = ofd.FileName;
            name.Text = new DirectoryInfo(ofd.FileName).Name;
            _readline(ofd.FileName);
            try
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                string tmp = sr.ReadToEnd();
                _appearContentWordChar(tmp);
                sr.Close();
            }
            catch
            {
                MessageBox.Show($"Can not read file {ofd.FileName}");
                return;
            }
        }
    }
}
