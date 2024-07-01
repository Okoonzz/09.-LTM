using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace lab4
{
    public partial class Bai2_1 : Form
    {
        private Bai2 bai2;
        private WebView2 webView;
        public Bai2_1(Bai2 form)
        {
            InitializeComponent();
            this.bai2 = form;
            InitializeAsync();
        }

        private void Bai2_1_Load(object sender, EventArgs e)
        {

        }

        private async void InitializeAsync()
        {
            try
            {
                string userAgent = bai2.SelectedUserAgent;
                string URL = bai2.SelectedWebsite;
                webView = new WebView2
                {
                    Dock = DockStyle.Fill,
                };
                Controls.Add(webView);
                await webView.EnsureCoreWebView2Async(null);
                webView.CoreWebView2.Settings.UserAgent = userAgent;
                webView.CoreWebView2.Navigate(URL);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
