using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcul
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private double dtb(double[] d, int len)
        {
            double tb = 0;
            foreach(double point in d)
            {
                tb += point;
            }
            return tb/len;
        }

        private int pointfail(double[] d)
        {
            int cnt = 0;
            foreach(double point in d)
            {
                if(point < 5)
                {
                    cnt++;
                }
            }
            return cnt;
        }

        private int pointpass(double[] d)
        {
            int cnt = 0;
            foreach(double point in d)
            {
                if(point >= 5)
                {
                    cnt++;
                }
            }
            return cnt;
        }

        private void xeploai(double[] d, double diemtb)
        {
            int cntgioi = 0;
            int cntkha = 0;
            int cnttb = 0;
            int cntyeu = 0;
            foreach(double point in d)
            {
                if(point < 6.5) cntgioi++;
                if(point < 5) cntkha++;
                if(point < 3.5) cnttb++;
                if (point < 2) cntyeu++;
            }

            if(diemtb >= 8 && cntgioi == 0)
            {
                xeploaibtn.Text = "Giỏi";
            }
            else if(diemtb >= 6.5 && cntkha == 0)
            {
                xeploaibtn.Text = "Khá";
            }
            else if(diemtb >= 5 && cnttb == 0)
            {
                xeploaibtn.Text = "Trung bình";
            }
            else if(diemtb >= 3.5 && cntyeu == 0)
            {
                xeploaibtn.Text = "Yếu";
            }
            else
            {
                xeploaibtn.Text = "Kém";
            }
        }

        private void appear_Click(object sender, EventArgs e)
        {
            res.Text = "";
            string tmp = pts.Text.Trim();
            if(tmp == "")
            {
                res.Text = "";
                dtbbtn.Text = "";
                maxbtn.Text = "";
                minbtn.Text = "";
                failbtn.Text = "";
                passbtn.Text = "";
                xeploaibtn.Text = "";
                MessageBox.Show("Please enter your points");
                return;
            }
            string[] numbers = tmp.Split(' ');
            double[] points = new double[numbers.Length];
            for(int i = 0; i <numbers.Length; i++)
            {
                if (double.TryParse(numbers[i], out points[i]))
                {
                    if (points[i] > 10 || points[i] < 0)
                    {
                        dtbbtn.Text = "";
                        maxbtn.Text = "";
                        minbtn.Text = "";
                        failbtn.Text = "";
                        passbtn.Text = "";
                        xeploaibtn.Text = "";
                        MessageBox.Show("Please enter correct points (0-10)");
                        return;
                    }
                }
                else
                {
                    dtbbtn.Text = "";
                    maxbtn.Text = "";
                    minbtn.Text = "";
                    failbtn.Text = "";
                    passbtn.Text = "";
                    xeploaibtn.Text = "";
                    MessageBox.Show("Please enter correct points!!!");
                    return;
                }
            }
            for(int i = 0; i < points.Length; i++)
            {
                res.Text += "Môn " + (i + 1) + ": " + points[i] + "đ" + "    ";
            }
            double pointavg = dtb(points, points.Length);
            dtbbtn.Text = Math.Round(pointavg,2).ToString();
            maxbtn.Text = points.Max().ToString();
            minbtn.Text = points.Min().ToString();
            failbtn.Text = pointfail(points).ToString();
            passbtn.Text = pointpass(points).ToString();
            xeploai(points, pointavg);
        }

        private void maxbtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void res_TextChanged(object sender, EventArgs e)
        {

        }

        private void minbtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
