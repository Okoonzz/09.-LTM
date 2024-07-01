using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }

        private int Priority(char op)
        {
            if (op == '+' || op == '-')
                return 1;
            if (op == '*' || op == '/')
                return 2;
            return 0;
        }

        private double PerformOperation(double a, double b, char op)
        {
            switch (op)
            {
                case '+': 
                    return a + b;
                case '-': 
                    return a - b;
                case '*': 
                    return a * b;
                case '/': 
                    return a / b;
                default: throw new ArgumentException("Invalid operator");
            }
        }

        private double EvaluateException(string expression)
        {
            Stack<double> numbers = new Stack<double>();
            Stack<char> operators = new Stack<char>();
            for (int i = 0; i < expression.Length; i++)
            {
                char c = expression[i];
                if (char.IsDigit(c))
                {
                    int num = 0;
                    while (i < expression.Length && char.IsDigit(expression[i]))
                    {
                        num = num * 10 + (expression[i] - '0');
                        i++;
                    }
                    i--;

                    numbers.Push(num);
                }
                else if (c == '(')
                {
                    operators.Push(c);
                }
                else if (c == ')')
                {
                    while (operators.Peek() != '(')
                    {
                        double b = numbers.Pop();
                        double a = numbers.Pop();
                        char op = operators.Pop();
                        numbers.Push(PerformOperation(a, b, op));
                    }
                    operators.Pop();
                }
                else if (IsOperator(c))
                {
                    while (operators.Count > 0 && Priority(operators.Peek()) >= Priority(c))
                    {
                        double b = numbers.Pop();
                        double a = numbers.Pop();
                        char op = operators.Pop();
                        numbers.Push(PerformOperation(a, b, op));
                    }
                    operators.Push(c);
                }
            }
            while (operators.Count > 0)
            {
                double b = numbers.Pop();
                double a = numbers.Pop();
                char op = operators.Pop();
                numbers.Push(PerformOperation(a, b, op));
            }
            return numbers.Pop();
        }
        private bool Check(string express)
        {
            foreach(char c in express)
            {
                if(c != '+' && c!= '-' && c!='*' && c!='/' && !('0' <= c && c <= '9') && c!='(' && c!= ')')
                {
                    return false;
                }
            }
            return true;
        }
        private void cal_Click(object sender, EventArgs e)
        {
            contentwrite.Clear();
            string expression = contentread.Text.Replace(" ", "").Trim();
            if (expression.Length == 0)
            {
                MessageBox.Show("Please enter the expression");
                return;
            }

            string[] tmpex = expression.Split(new char[] {'\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            foreach(string s in tmpex)
            {
                bool _check = true;
                _check = Check(s);
                if (_check == false)
                {
                    MessageBox.Show("Please enter the correct expression containing numbers (0-9) and operators (+,-,*,/)");
                    return;
                }
            }
            double[] res = new double[tmpex.Length];
            for(int i = 0; i < tmpex.Length; i++)
            {
                res[i] = EvaluateException(tmpex[i]);
                if (res[i] == double.NegativeInfinity || res[i] == double.PositiveInfinity)
                {
                    contentwrite.Text = "";
                    MessageBox.Show($"{tmpex[i]} error div 0");
                    return;
                }
                else
                {
                    contentwrite.Text += tmpex[i] + "=" + res[i].ToString() + '\n';
                }
            }
        }

        private void readfl_Click(object sender, EventArgs e)
        {
            contentread.Text = "";
            contentwrite.Text = "";
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Select file";
                ofd.Filter = "Text File (*.txt)|*.txt";
                ofd.ShowDialog();

                StreamReader sr = new StreamReader(ofd.FileName);
                string tmp = sr.ReadToEnd();
                contentread.Text = tmp;
                sr.Close();
            }
            catch
            {
                MessageBox.Show("Cant Read file.");
                return ;
            }

        }

        private void writefl_Click(object sender, EventArgs e)
        {
            try
            {
                if (contentwrite.Text.Trim() == "")
                {
                    MessageBox.Show("Please calculate in advance");
                    return;
                }
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Select File";
                sfd.Filter = "Text File (*.txt)|*.txt";
                sfd.ShowDialog();
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);

                byte[] buffer = Encoding.UTF8.GetBytes(contentwrite.Text.Trim());
                try
                {
                    fs.Write(buffer, 0, buffer.Length);
                    fs.Close();
                    MessageBox.Show($"Done write to {sfd.FileName}");
                    return;
                }
                catch
                {
                    MessageBox.Show($"Can not save to file {sfd.FileName}");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Can not open.");
                return;
            }
        }
    }
}
