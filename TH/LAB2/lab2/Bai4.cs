using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;


namespace lab2
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai41 ba4_1 = new Bai41();
            ba4_1.ShowDialog();
            ba4_1.fs.Close();
        }
        private void SaveToExcel()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Select File";
            sfd.Filter = "Excel File (*.xlsx)|*.xlsx";
            sfd.ShowDialog();
            try
            {
                Excel.Application xlApp = new Excel.Application();

                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                xlWorkBook = xlApp.Workbooks.Add();
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets[1];

                xlWorkSheet.Cells[1, 1] = "MSSV";
                xlWorkSheet.Cells[1, 2] = "Họ tên";
                xlWorkSheet.Cells[1, 3] = "SDT";
                xlWorkSheet.Cells[1, 4] = "Toán";
                xlWorkSheet.Cells[1, 5] = "Văn";
                xlWorkSheet.Cells[1, 6] = "ĐTB";

                using (StreamReader sr = new StreamReader("input.txt"))
                {
                    string contents = "";
                    int row = 2;
                    while ((contents = sr.ReadLine()) != null)
                    {
                        string[] _content = contents.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                        double math;
                        double lit;
                        if (!((double.TryParse(_content[3], out math)) && (double.TryParse(_content[4], out lit))))
                        {
                            MessageBox.Show("Points is not valid");
                            return;
                        }

                        xlWorkSheet.Cells[row, 1] = _content[0];
                        xlWorkSheet.Cells[row, 2] = _content[1];
                        xlWorkSheet.Cells[row, 3] = "'" + _content[2];
                        xlWorkSheet.Cells[row, 4] = _content[3];
                        xlWorkSheet.Cells[row, 5] = _content[4];
                        xlWorkSheet.Cells[row, 6] = (math + lit) / 2;

                        row++;
                    }
                    sr.Close();

                }
                xlWorkBook.SaveAs(sfd.FileName);

                xlWorkBook.Close();
                xlApp.Quit();
                MessageBox.Show($"Done save to {sfd.FileName}");
                Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlApp);
            }
            catch
            {
                MessageBox.Show($"Can not open/create {sfd.FileName}");
            }
        }


                    
    private void button2_Click(object sender, EventArgs e)
        {
            SaveToExcel();
        }

    private void LoadDataFromExcel(string fpath, string ext, string hdr)
        {
            string con = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
            con = String.Format(con, fpath, hdr);
            OleDbConnection excelcon = new OleDbConnection(con);
            excelcon.Open();
            DataTable exceldata = excelcon.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            string exsheetname = exceldata.Rows[0]["TABLE_NAME"].ToString();
            OleDbCommand com = new OleDbCommand("Select * from [" + exsheetname + "]", excelcon);
            OleDbDataAdapter oda = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            excelcon.Close();
            dataGridView1.DataSource = dt;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select File";
            ofd.Filter = "Excel File (*.xlsx)|*.xlsx";
            ofd.ShowDialog();


            LoadDataFromExcel(ofd.FileName, ".xlsx", "yes");
        }

        private void Bai4_Load(object sender, EventArgs e)
        {

        }
    }
}
