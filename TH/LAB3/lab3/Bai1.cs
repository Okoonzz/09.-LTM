using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace lab3
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void Bai1_Load(object sender, EventArgs e)
        {

        }
        private void _show()
        {

        }
        private bool isClientShown = false;
        private void client_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Application.Run(new Bai1_client());
            });

        }

        private void server_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                CheckForIllegalCrossThreadCalls = false;
                Application.Run(new Bai1_server());
            });
        }
    }
}
