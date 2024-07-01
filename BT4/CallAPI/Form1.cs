using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace CallAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public const string apiKey = "tự thay key của m vào, không thì đi chôm";
        private string URL = $"https://www.googleapis.com/youtube/v3/videos?part=snippet,statistics&chart=mostPopular&regionCode=VN&maxResults=10&key={apiKey}";
        private string[] title = new string[10];
        private string[] views = new string[10];
        private string[] channels = new string[10];
        private string[] _url = new string[10];

        private void appear()
        {
            tit1.Text = title[0];
            v1.Text = views[0];
            c1.Text = channels[0];
            u1.Text = "http://youtu.be/" + _url[0];

            tit2.Text = title[1];
            v2.Text = views[1];
            c2.Text = channels[1];
            u2.Text = "http://youtu.be/" + _url[1];

            tit3.Text = title[2];
            v3.Text = views[2];
            c3.Text = channels[2];
            u3.Text = "http://youtu.be/" + _url[2];

            tit4.Text = title[3];
            v4.Text = views[3];
            c4.Text = channels[3];
            u4.Text = "http://youtu.be/" + _url[3];

            tit5.Text = title[4];
            v5.Text = views[4];
            c5.Text = channels[4];
            u5.Text = "http://youtu.be/" + _url[4];

            tit6.Text = title[5];
            v6.Text = views[5];
            c6.Text = channels[5];
            u6.Text = "http://youtu.be/" + _url[5];

            tit7.Text = title[6];
            v7.Text = views[6];
            c7.Text = channels[6];
            u7.Text = "http://youtu.be/" + _url[6];

            tit8.Text = title[7];
            v8.Text = views[7];
            c8.Text = channels[7];
            u8.Text = "http://youtu.be/" + _url[7];

            tit9.Text = title[8];
            v9.Text = views[8];
            c9.Text = channels[8];
            u9.Text = "http://youtu.be/" + _url[8];

            tit10.Text = title[9];
            v10.Text = views[9];
            c10.Text = channels[9];
            u10.Text = "http://youtu.be/" + _url[9];
        }

        private void _clear()
        {
            tit1.Text = "";
            v1.Text = "";
            c1.Text = "";
            u1.Text = "";

            tit2.Text = "";
            v2.Text = "";
            c2.Text = "";
            u2.Text = "";

            tit3.Text = "";
            v3.Text = "";
            c3.Text = "";
            u3.Text = "";

            tit4.Text = "";
            v4.Text = ""    ;
            c4.Text = "";
            u4.Text = "";

            tit5.Text = "";
            v5.Text = "";
            c5.Text = "";
            u5.Text = "";

            tit6.Text = "";
            v6.Text = "";
            c6.Text = "";
            u6.Text = "";

            tit7.Text = "";
            v7.Text = "";
            c7.Text = "";
            u7.Text = "";

            tit8.Text = "";
            v8.Text = "";
            c8.Text = "";
            u8.Text = "";

            tit9.Text = "";
            v9.Text = "";
            c9.Text = "";
            u9.Text = "";

            tit10.Text = "";
            v10.Text = "";
            c10.Text = "";
            u10.Text = "";
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    _clear();
                    client.BaseAddress = new Uri(URL);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response =  client.GetAsync(URL).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        string dataObjects = await response.Content.ReadAsStringAsync();
                        dynamic content = JObject.Parse(dataObjects);
                        JArray items = content.items;

                        for(int i = 0; i < 10; i++)
                        {
                            title[i] = items[i]["snippet"]["title"].ToString();
                            channels[i] = items[i]["snippet"]["channelTitle"].ToString();
                            views[i] = items[i]["statistics"]["viewCount"].ToString();
                            _url[i] = items[i]["id"].ToString();
                        }
                        appear();
                    }
                    else
                    {
                        MessageBox.Show("Không thể lấy dữ liệu từ API.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }
        }

        private void u1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start($"http://youtu.be/{_url[0]}");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start($"http://youtu.be/{_url[3]}");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void u2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start($"http://youtu.be/{_url[1]}");
        }

        private void u3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start($"http://youtu.be/{_url[2]}");
        }

        private void u5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start($"http://youtu.be/{_url[4]}");
        }

        private void u6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start($"http://youtu.be/{_url[5]}");
        }

        private void u7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start($"http://youtu.be/{_url[6]}");
        }

        private void u8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start($"http://youtu.be/{_url[7]}");
        }

        private void u9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start($"http://youtu.be/{_url[8]}");
        }

        private void u10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start($"http://youtu.be/{_url[9]}");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tit1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
