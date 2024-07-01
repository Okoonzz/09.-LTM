using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace lab4
{
    public partial class Bai2 : Form
    {
        public string SelectedUserAgent { get; private set; }
        public string SelectedWebsite { get; private set; }

        public Bai2()
        {
            InitializeComponent();
        }
        Dictionary<string, string> userAgents = new Dictionary<string, string>
            {
                { "Chrome - Android Mobile", "Mozilla/5.0 (Linux; Android 6.0; Nexus 5 Build/MRA58N) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/124.0.0.0 Mobile Safari/537.36" },
                { "Chorme - Android Mobile (high-end)", "Mozilla/5.0 (Linux; Android 10; Pixel 4) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/124.0.0.0 Mobile Safari/537.36" },
                {"Chorme - Android Tablet", "Mozilla/5.0 (Linux; Android 4.3; Nexus 7 Build/JSS15Q) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/124.0.0.0 Safari/537.36" },
                {"Chorme - iphone", "Mozilla/5.0 (iPhone; CPU iPhone OS 13_2 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) CriOS/124.0.0.0 Mobile/15E148 Safari/604.1" },
                {"Chrome - iPad", "Mozilla/5.0 (iPad; CPU OS 13_2 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) CriOS/124.0.0.0 Mobile/15E148 Safari/604.1" },
                {"Chorme - Chorme OS", "Mozilla/5.0 (X11; CrOS x86_64 10066.0.0) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/124.0.0.0 Safari/537.36" },
                {"Chorme - Mac", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/124.0.0.0 Safari/537.36" },
                {"Chorme - Windows", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/124.0.0.0 Safari/537.36" }
            };
        private void Bai2_Load(object sender, EventArgs e)
        {
            foreach (var userAgent in userAgents)
            {
                boxUA.Items.Add(userAgent.Key);
            }
        }
        private void txtURL_TextChanged(object sender, EventArgs e)
        {
            SelectedWebsite = txtURL.Text.Trim();

        }

        private void boxUA_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            // Retrieve the selected value based on the selected key
            string selectedKey = boxUA.SelectedItem.ToString();

            if (userAgents.TryGetValue(selectedKey, out string selectedValue))
            {
                SelectedUserAgent = selectedValue;
                DialogResult = DialogResult.OK;
            }
        }

        private void btnbrowser_Click(object sender, EventArgs e)
        {
            if (SelectedWebsite == null)
            {
                MessageBox.Show("Please enter your website's URL");
               return;
            }

            if (!SelectedWebsite.StartsWith("http://") && !SelectedWebsite.StartsWith("https://"))
            {
                MessageBox.Show("Please enter correct website");
                return;
            }

            Thread thread = new Thread(() =>
            {
                Bai2_1 bai2_1 = new Bai2_1(this);
                bai2_1.ShowDialog();
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
