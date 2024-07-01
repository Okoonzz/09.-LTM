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
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace lab4
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        public const string apiKey = "AIzaSyCoG7zFdpGR7OLdvJYLkfgfu0op-g91kZY";
        private string URL = $"https://www.googleapis.com/youtube/v3/videos?part=snippet,statistics&chart=mostPopular&regionCode=VN&maxResults=10&key={apiKey}";
        private string[] title = new string[10];
        private string[] views = new string[10];
        private string[] channels = new string[10];
        private string[] _url = new string[10];
        private string[] _image = new string[10];
        private List<Bitmap> bitmapList = new List<Bitmap>();


        private void appear()
        {
            title1.Text = title[0];
            view1.Text = views[0];
            channel1.Text = channels[0];
            url1.Text = "https://youtu.be/" + _url[0];
            pictureBox1.Image = bitmapList[0];

            title2.Text = title[1];
            view2.Text = views[1];
            channel2.Text = channels[1];
            url2.Text = "https://youtu.be/" + _url[1];
            pictureBox2.Image = bitmapList[1];

            title3.Text = title[2];
            view3.Text = views[2];
            channel3.Text = channels[2];
            url3.Text = "https://youtu.be/" + _url[2];
            pictureBox3.Image = bitmapList[2];

            title4.Text = title[3];
            view4.Text = views[3];
            channel4.Text = channels[3];
            url4.Text = "https://youtu.be/" + _url[3];
            pictureBox4.Image = bitmapList[3];

            title5.Text = title[4];
            view5.Text = views[4];
            channel5.Text = channels[4];
            url5.Text = "https://youtu.be/" + _url[4];
            pictureBox5.Image = bitmapList[4];

            title6.Text = title[5];
            view6.Text = views[5];
            channel6.Text = channels[5];
            url6.Text = "https://youtu.be/" + _url[5];
            pictureBox6.Image = bitmapList[5];

            title7.Text = title[6];
            view7.Text = views[6];
            channel7.Text = channels[6];
            url7.Text = "https://youtu.be/" + _url[6];
            pictureBox7.Image = bitmapList[6];

            title8.Text = title[7];
            view8.Text = views[7];
            channel8.Text = channels[7];
            url8.Text = "https://youtu.be/" + _url[7];
            pictureBox8.Image = bitmapList[7];

            title9.Text = title[8];
            view9.Text = views[8];
            channel9.Text = channels[8];
            url9.Text = "https://youtu.be/" + _url[8];
            pictureBox9.Image = bitmapList[8];

            title10.Text = title[9];
            view10.Text = views[9];
            channel10.Text = channels[9];
            url10.Text = "https://youtu.be/" + _url[9];
            pictureBox10.Image = bitmapList[9];
        }

        

        private void addImage(string[] url)
        {
            for (int i = 0; i < url.Length; i++)
            {
                string tmpURL = url[i];
                WebRequest request = WebRequest.Create(tmpURL);
                WebResponse response = request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                Bitmap bitmap = new Bitmap(responseStream);

                // Thêm Bitmap vào danh sách
                bitmapList.Add(bitmap);
            }
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
/*                    _clear();*/
                    client.BaseAddress = new Uri(URL);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.GetAsync(URL).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        string dataObjects = await response.Content.ReadAsStringAsync();
                        dynamic content = JObject.Parse(dataObjects);
                        JArray items = content.items;

                        for (int i = 0; i < 10; i++)
                        {
                            title[i] = items[i]["snippet"]["title"].ToString();
                            channels[i] = items[i]["snippet"]["channelTitle"].ToString();
                            views[i] = items[i]["statistics"]["viewCount"].ToString();
                            _url[i] = items[i]["id"].ToString();
                            _image[i] = items[i]["snippet"]["thumbnails"]["default"]["url"].ToString();
                        }
                        addImage(_image);
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

        private void textBox35_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start($"https://youtu.be/{_url[0]}");
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start($"https://youtu.be/{_url[1]}");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start($"https://youtu.be/{_url[2]}");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start($"https://youtu.be/{_url[3]}");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start($"https://youtu.be/{_url[4]}");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start($"https://youtu.be/{_url[5]}");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start($"https://youtu.be/{_url[6]}");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start($"https://youtu.be/{_url[7]}");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start($"https://youtu.be/{_url[8]}");
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start($"https://youtu.be/{_url[9]}");
        }
    }
}
