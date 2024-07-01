using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab4
{
    public partial class Bai4 : Form
    {

        public string selectURL { get; private set; }

        public Bai4()
        {
            InitializeComponent();
            txturl.KeyDown += Txturl_KeyDown;
            
        }

        private void Txturl_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra xem phím được nhấn có phải là Enter hay không
            if (e.KeyCode == Keys.Enter)
            {
                // Gọi phương thức btnbrowser_Click
                btnbrowser_Click(sender, e);
            }
        }


        private void CoreWebView2_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            // Cập nhật TextBox với URL mới
            txturl.Text = webView21.CoreWebView2.Source.ToString();
            selectURL = txturl.Text;
        }

        public HashSet<KeyValuePair<string, string>> headersList = new HashSet<KeyValuePair<string, string>>();

        public void CoreWebView2_WebResourceRequested(object sender, CoreWebView2WebResourceRequestedEventArgs e)
        {
            CoreWebView2HttpRequestHeaders headers = e.Request.Headers;
            foreach (var header in headers)
            {
                headersList.Add(new KeyValuePair<string, string>(header.Key, header.Value));
            }
        }

        private bool isBrowserButtonClicked = false;
        private async void btnbrowser_Click(object sender, EventArgs e)
        {
            try
            {
                string URL = txturl.Text.Trim();

                if (URL.Length == 0)
                {
                    MessageBox.Show("Please enter your website's URL");
                    return;
                }

                if (!URL.StartsWith("http://") && !URL.StartsWith("https://"))
                {
                    MessageBox.Show("Please enter correct website");
                    return;
                }

                webView21.Dock = DockStyle.Fill;
                await webView21.EnsureCoreWebView2Async(null);
                webView21.CoreWebView2.NavigationCompleted += CoreWebView2_NavigationCompleted;

                // Thêm một bộ lọc cho tất cả các yêu cầu
                webView21.CoreWebView2.AddWebResourceRequestedFilter("*", CoreWebView2WebResourceContext.All);

                // Đăng ký sự kiện WebResourceRequested
                webView21.CoreWebView2.WebResourceRequested += CoreWebView2_WebResourceRequested;

                selectURL = txturl.Text;
                webView21.CoreWebView2.Navigate(URL);
                isBrowserButtonClicked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Bai4_Load(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            webView21.GoBack();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            webView21.GoForward();
        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            if (!isBrowserButtonClicked)
            {
                MessageBox.Show("Enter Browser in advance");
                return ;
            }
            if (!webView21.CoreWebView2.Source.ToString().Equals("about:blank"))
            {
                webView21.Reload();
            }

        }

        private string savePath;
        private async void btndownload_Click(object sender, EventArgs e)
        {
            if (!isBrowserButtonClicked)
            {
                MessageBox.Show("Enter Browser in advance");
                return;
            }
            using (var ofd = new FolderBrowserDialog())
            {
                DialogResult result = ofd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(ofd.SelectedPath))
                {
                    savePath = ofd.SelectedPath;

                    string URL = txturl.Text.Trim();
                    var web = new HtmlWeb();
                    var doc = await Task.Factory.StartNew(() => web.Load(URL));
                    var nodeCollection = doc.DocumentNode.DescendantsAndSelf();

                    //download HTML
                    using (var client = new WebClient())
                    {
                        var htmlContent = await client.DownloadStringTaskAsync(URL);
                        string path = Path.Combine(savePath, "index.html");

                        using (StreamWriter writer = new StreamWriter(path))
                        {
                            await writer.WriteAsync(htmlContent);
                        }
                    }

                    //download all file
                    foreach (var node in nodeCollection)
                    {
                        try
                        {
                            if (node.Name == "img" || node.Name == "script" || node.Name == "link")
                            {
                                var attribute = node.Name == "link" ? "href" : "src";
                                var path = node.GetAttributeValue(attribute, null);
                                if (path != null)
                                {
                                    // Kiểm tra xem đường dẫn có phải là đường dẫn tuyệt đối hay không
                                    var uri = path.StartsWith("http") ? new Uri(path) : new Uri(new Uri(URL), path);
                                    string folderName = node.Name == "link" ? "css" : node.Name;
                                    DownloadFile(uri, folderName);
                                }
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
 
                    }
                    MessageBox.Show($"Download Done Your Files in {savePath}");
                }
            }
        }


        private void DownloadFile(Uri uri, string folderName)
        {
            if (!isBrowserButtonClicked)
            {
                MessageBox.Show("Enter Browser in advance");
                return;
            }
            using (var client = new WebClient())
            {
                try
                {
                    var path = Path.Combine(savePath, folderName, Path.GetFileName(uri.LocalPath)); // Thay đổi đường dẫn này thành nơi bạn muốn lưu tệp
                    Directory.CreateDirectory(Path.GetDirectoryName(path));
                    client.DownloadFile(uri, path);
                }
                catch
                {

                }

            }
        }
        private void btnviewsource_Click(object sender, EventArgs e)
        {
            if (!isBrowserButtonClicked)
            {
                MessageBox.Show("Enter Browser in advance");
                return;
            }
            Task.Run(() =>
            {
                    Bai4_1 bai41 = new Bai4_1(this);
                    bai41.ShowDialog();

            });

        }
    }
}
