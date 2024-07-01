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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab4
{
    public partial class Bai4_1 : Form
    {
        private Bai4 bai4;
        public Bai4_1(Bai4 bai4)
        {
            InitializeComponent();
            this.bai4 = bai4;

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Bai4_1_Load(object sender, EventArgs e)
        {
            Init();
            txtURL.Text = bai4.selectURL;
        }

        private void Init()
        {
            WebRequest myWebRequest = WebRequest.Create(bai4.selectURL);
            WebResponse myWebResponse = myWebRequest.GetResponse();
            DisplaySource(myWebResponse);
            DisplayHeaderRes(myWebResponse);
            DisplayHeaderReq(myWebRequest);
        }

        private void DisplaySource(WebResponse myWebResponse)
        {
                Stream dataStream = myWebResponse.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                txtsource.Text = responseFromServer;
        }

        private void DisplayHeaderRes(WebResponse myWebResponse)
        {
            for (int i = 0; i < myWebResponse.Headers.Count; ++i)
            {
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(myWebResponse.Headers.Keys[i]);
                item.SubItems.Add(myWebResponse.Headers[i]);
                listviewres.Items.Add(item);
            }
        }

        private void DisplayHeaderReq(WebRequest myWebRequest)
        {
            int i = 0;
            foreach (var header in bai4.headersList)
            {
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(header.Key);
                item.SubItems.Add(header.Value);
                listviewreq.Items.Add(item);
                i++;
            }

        }



    }
}
