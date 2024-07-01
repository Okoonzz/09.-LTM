using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _Create()
        {
            try
            {
                FormClient formClient = new FormClient();
                formClient.ShowDialog();
            }
            catch
            {
                return;
            }

        }

        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            Thread newClient = new Thread(_Create);
            newClient.Start();
        }
    }
}
