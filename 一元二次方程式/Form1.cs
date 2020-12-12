using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 一元二次方程式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                richTextBox1.Text = "請確認是否皆輸入完成";
                return;
            }
            int a, b, c;
            double x1,x2;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = int.Parse(textBox3.Text);
            double delt = b * b - 4 * a * c;
            if (delt > 0)
            {
                x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
                x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
                richTextBox1.Text = "Two different roots \n"+"x1 = " + x1 + "," + "x2 = " + x2;
            }
            else if (b * b - 4 * a * c == 0)
            {
                x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
                richTextBox1.Text = "Two same roots \n"+"x = " + x1;
            }
            else
            {
                richTextBox1.Text = "No real root";
            }
        }
    }
}
