using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace lab4
{
    public partial class Bai3NangCao : Form
    {

        public Bai3NangCao()
        {
            InitializeComponent();
            _init();


        }

        private string[] city = new string[5];
        private string[] date = new string[5];
        private string[] time_current = new string[5];
        private string[] time_forward = new string[5];
        private string[] amount = new string[5];


        private void _init()
        {
            txtdate1.SelectionAlignment = HorizontalAlignment.Center;
            txtdate2.SelectionAlignment = HorizontalAlignment.Center;
            txtdate3.SelectionAlignment = HorizontalAlignment.Center;
            txtdate4.SelectionAlignment = HorizontalAlignment.Center;
            txtdate5.SelectionAlignment = HorizontalAlignment.Center;
            f1.SelectionAlignment = HorizontalAlignment.Center;
            f2.SelectionAlignment = HorizontalAlignment.Center;
            f3.SelectionAlignment = HorizontalAlignment.Center;
            f4.SelectionAlignment = HorizontalAlignment.Center;
            f5.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void disPlay()
        {
            txtcity1.Text = city[0];
            txtdate1.Text = date[0] + '\n' + time_current[0];
            f1.Text = time_forward[0] + '\n' + amount[0] ;

            txtcity2.Text = city[1];
            txtdate2.Text = date[1] + '\n' + time_current[1];
            f2.Text = time_forward[1] + '\n' + amount[1];

            txtcity3.Text = city[2];
            txtdate3.Text = date[2] + '\n' + time_current[2];
            f3.Text = time_forward[2] + '\n' + amount[2];

            txtcity4.Text = city[3];
            txtdate4.Text = date[3] + '\n' + time_current[3];
            f4.Text = time_forward[3] + '\n' + amount[3];

            txtcity5.Text = city[4];
            txtdate5.Text = date[4] + '\n' + time_current[4];
            f5.Text = time_forward[4] + '\n' + amount[4];
        }

        private void Bai3NangCao_Load(object sender, EventArgs e)
        {
             
        }

        private bool isstart = false;
        private void btnstart_Click(object sender, EventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string webApp2Path = Path.Combine(currentDirectory, "..", "CreateAPI", "createAPI.exe");
            System.Diagnostics.Process.Start(webApp2Path);
            isstart = true;
        }

        private string URL;

        private async void btnReq_Click(object sender, EventArgs e)
        {
            if(!isstart)
            {
                MessageBox.Show("Please run server in advance");
                return;
            }
            if(txtport.Text.Trim() == null)
            {
                MessageBox.Show("Please Enter Port");
                return;
            }
            URL = $"http://localhost:{txtport.Text.Trim()}/precipitation";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri(URL);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.GetAsync(URL).Result;
          
                    if (response.IsSuccessStatusCode)
                    {
                        string dataObjects = await response.Content.ReadAsStringAsync();
                        dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(dataObjects);
                        for (int i = 0; i < 5; i++)
                        {
                            city[i] = data[i].city.ToString();
                            date[i] = data[i].date.ToString();
                            amount[i] = data[i].amount.ToString();
                            time_current[i] = data[i].time_cur.ToString();
                            time_forward[i] = data[i].time_for.ToString();
                        }
                        disPlay();
                    }
                    else
                    {
                        MessageBox.Show("Unable to get data from API.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Err: {ex.Message}");
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
