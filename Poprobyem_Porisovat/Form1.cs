using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poprobyem_Porisovat
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Graphics g = graphWind.CreateGraphics();
            //Создание и установка цвета пера 
            Pen myPen = new Pen(Color.Red);                 
            int nmbInterv = 100;                          //Количество точек на графике 
            float xmin = 0, xmax = 6f * 3.14f;                    
            float xstep = (xmax - xmin) / nmbInterv;

            float x1 = xmin, y1 = xmin;
            float ymin = float.MaxValue, ymax = float.MinValue;

            for (int i = 0; i < nmbInterv; i++) // определяем мин и мач ф-ии по У
            {
                float x2 = x1 + xstep;       //Координаты 
                float y2 = Convert.ToSingle((Math.Sin(2 * 3.14 - x2)) * Math.Exp(x2));
                if (y2 > ymax) ymax = y2;
                if (y2 < ymin) ymin = y2;
                x1 = x2;
                y1 = y2;
            }

            float kx = graphWind.Width / (xmax - xmin) , ky = graphWind.Height / (ymax - ymin) ;
            x1 = xmin;
            y1 = xmin;
             
            for (int i = 0; i < nmbInterv; i++)
            {
                float x2 = x1 + xstep;   
                float y2 = Convert.ToSingle((Math.Sin(2*3.14-x2))*Math.Exp(x2));          
                g.DrawLine(myPen, kx * x1- 9, graphWind.Height - ky * y1-24, kx * x2- 9 , graphWind.Height - ky * y2-24);
                ch1.Series[0].Points.AddXY(x2, y2);
                x1 = x2;                     
                y1 = y2;                     
            }
             
            Font fnt = new Font("Arial", 10);  
            g.DrawString("y=Sin(2π∗x)∗exp(x) \r\n ", fnt, new SolidBrush(Color.Red), 10, 560);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
