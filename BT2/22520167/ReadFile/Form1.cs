using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ReadFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Multiselect = true,
            };

            ofd.Title = "Select File";
            ofd.InitialDirectory = @"C:\";
            ofd.Filter = "All files (*.*)|*.*|Text File (*.txt)|*.txt";
            ofd.FilterIndex = 0;
            ofd.ShowDialog();

            foreach (object filename in ofd.FileNames)
            {
                Thread newthread = new Thread(new ParameterizedThreadStart(lineFile));
                newthread.Start(filename);
            }
        }

        private void lineFile(object files)
        {
            string filename = (string)files;
            int cnt = 0;

            using (StreamReader sr = new StreamReader(filename))
            {
                while (sr.ReadLine() != null)
                {
                    cnt++;
                }
            }
            this.Invoke(new Action(() =>
            {
                ctpath.Text += $"{filename} has {cnt} lines\n";
            }));
        }
    }
}
