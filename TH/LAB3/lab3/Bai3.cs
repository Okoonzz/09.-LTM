using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        public int cntServer = 0;
        public int cntClient = 0;

        public void ResetCountsServer()
        {
            cntServer = 0;
            
        }

        public void ResetCountsClient()
        {
            cntClient = 0;

        }
        private void btnServer_Click(object sender, EventArgs e)
        {
            if(cntServer == 0)
            {
                cntServer++;
                Task.Run(() =>
                {
                    Bai3_server serverForm = new Bai3_server();
                    serverForm.FormClosing += (s, args) => ResetCountsServer();
                    Application.Run(serverForm);
                });

            }
            else
            {
                return;
            }

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            if(cntClient == 0)
            {
                cntClient++;
                Task.Run(() =>
                {
                    Bai3_client clientForm = new Bai3_client();
                    clientForm.FormClosing += (s, args) => ResetCountsClient();
                    Application.Run(clientForm);
                });
            }
            else { return; }

        }

        private void Bai3_Load(object sender, EventArgs e)
        {

        }
    }
}
