using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void _clear()
        {
            txtcontent.Clear();
            listView1.Items.Clear();
        }
        private bool _check()
        {
            if(txturl.Text.Trim().Length == 0) return false;
            return true;
        }

        private void DisplayHeader(WebResponse myWebResponse)
        {
            for (int i = 0; i < myWebResponse.Headers.Count; ++i)
            {
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(myWebResponse.Headers.Keys[i]);
                item.SubItems.Add(myWebResponse.Headers[i]);
                listView1.Items.Add(item);
            }
        }

        private void DisplayHTML(WebResponse myWebResponse)
        {
            Stream dataStream = myWebResponse.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            txtcontent.Text = responseFromServer;
        }

        private void btndownload_Click(object sender, EventArgs e)
        {
            if (!_check())
            {
                MessageBox.Show("Please enter URL web");
                return;  
            }
            try
            {
                _clear();
                WebRequest myWebRequest = WebRequest.Create(txturl.Text.Trim());
                WebResponse myWebResponse = myWebRequest.GetResponse();
                DisplayHTML(myWebResponse);
                DisplayHeader(myWebResponse);
                myWebResponse.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void Bai1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
