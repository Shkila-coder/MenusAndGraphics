using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using the1._5._1;

namespace BaluemcaANDbombim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
      

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();

            double x1, x2, h;
            string S, Y, X;
            richTextBox1.Text = null;
            richTextBox2.Text = null;
            richTextBox3.Text = null;
            try
            {
                x1 = Convert.ToDouble(textBox1.Text);
                x2 = Convert.ToDouble(textBox2.Text);
                h = (x2 - x1) / 10.0;
                for (double x = x1; x <= x2; x += h)
                {
                    X = Convert.ToString(x);
                    Y = Convert.ToString(Math.Round(Class1MyLibrary.MathATan(x), 5));
                    S = Convert.ToString(Math.Round(Class1MyLibrary.MathATan2(x), 5));
                    //richTextBox1.Text = richTextBox1.Text + "При х = " + X + " | Y(x) = " + Y + " | S(x) = " + S + "\r\n";
                    richTextBox1.Text = richTextBox1.Text + "При х = " + X + "\r\n" + "-------" + "\r\n";
                    richTextBox2.Text = richTextBox2.Text + "Y(x) = " + Y + "\r\n" + "-------" + "\r\n";
                    richTextBox3.Text = richTextBox3.Text + "S(x) = " + S + "\r\n" + "-------" + "\r\n";
                    chart1.Series[0].Points.AddXY(x, Convert.ToDouble(Y));
                    chart1.Series[1].Points.AddXY(x, Convert.ToDouble(S));
                    chart1.Series[2].Points.AddXY(x, Convert.ToDouble(Y)- Convert.ToDouble(S));
                }

            }
            catch
            {
                MessageBox.Show("Неверный формат введенных данных");
                richTextBox1.Text = "Error";
                richTextBox2.Text = "Error";
                richTextBox3.Text = "Error";
            }
        }
    }
}
