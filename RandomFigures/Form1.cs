using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomFigures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Создание "Художника" и привязка его к "холсту" grWind 
            Graphics g = graphWind.CreateGraphics();
            //Создание и установка цвета пера 
            Pen myPen = new Pen(Color.Red);                //Красный цвет 
            int nmbInterv = 100;                          //Количество точек на графике 
            float xmin = 0, xmax =1000;                     //Диапазон изменения аргумента х 
            float xstep = (xmax - xmin) / nmbInterv;      //Шаг по аргументу 
            float ymin = xmin, ymax = 250;           //Диапазон изменения функции y= x^2 
            //Коэффициенты пересчета абсолютных координат в координаты "холста" 
            float kx = graphWind.Width / (xmax - xmin), ky = graphWind.Height / (ymax - ymin);
            float x1 = xmin, y1 = ymin;                //Первая точка графика 
            Font fnt = new Font("Arial", 30);  //Шрифт Arial, размер 10 
            Random rnd = new Random();
            int value = rnd.Next(6, 10); // случайное кол-во фигур


            for (int i = 0; i < value; i++)
            {
                 value = rnd.Next(0, 5); // определяем номер фигуры случайно 
                if (value == 0) //создание линии
                {
                    float x = rnd.Next(0, 1000);
                    float y = rnd.Next(0, 250);
                    float x_1 = rnd.Next(0, 1000);
                    float y_1 = rnd.Next(0, 250);
                    g.DrawLine(new Pen(Color.Black), x, y, x_1, y_1);
                }
                else if (value == 1) // создание круга
                {
                    float a = rnd.Next(0, 100);
                    float x = rnd.Next(0, 1000);
                    float y = rnd.Next(0, 250);
                    g.DrawEllipse(new Pen(Color.Green), x, y, a, a);
                }
                else if (value == 2) // создание эллипсов
                {
                    float b= rnd.Next(0, 100);
                    float a = rnd.Next(0, 100);
                    float x = rnd.Next(0, 1000);
                    float y = rnd.Next(0, 250);
                    g.DrawEllipse(new Pen(Color.Yellow), x, y, a, b);
                }
                else if (value == 3) // создание прямоугольников
                {
                    float b = rnd.Next(0, 100);
                    float a = rnd.Next(0, 100);
                    float x = rnd.Next(0, 1000);
                    float y = rnd.Next(0, 250);
                    g.DrawRectangle(myPen, x, y, a, b);
                }
                else if (value == 4) // создание букв
                {
                    float b = rnd.Next(0, 1000);
                    float a = rnd.Next(0, 100);
                    char s = (char)(rnd.Next(1040, 1104));
                    g.DrawString(Convert.ToString(s), fnt, new SolidBrush(Color.Blue), b, a);
                }

            }
            //g.DrawRectangle(myPen, 10, 10, 100, 100);
            //Вывод текста 
           // Font fnt = new Font("Arial", 10);  //Шрифт Arial, размер 10 
           // g.DrawString("y=Sin(2π∗x)∗exp(x) \r\n ", fnt, new SolidBrush(Color.Red), 10, 10);
        }
    }
}
