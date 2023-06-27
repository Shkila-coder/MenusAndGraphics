using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delaem_menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "";
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Выбранно Объект->Сотрудник", "Внимание!", MessageBoxButtons.OKCancel);
        }

        private void договорToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Выбранно Объект->Сотрудник", "Внимание!", MessageBoxButtons.OKCancel);
        }


        //блок с сообщениями 

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rsl = MessageBox.Show("Закрыть приложение?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rsl == DialogResult.Yes)
                Application.Exit(); 
        }

        private void сотрудникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выбранно Объект->Сотрудник", "Внимание!", MessageBoxButtons.OKCancel);
        }

        private void клиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выбранно Объект->Клиент", "Внимание!", MessageBoxButtons.OKCancel);
        }

        private void договорToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Выбранно Объект->Договор", "Внимание!", MessageBoxButtons.OKCancel);
        }

        private void поручениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выбранно Объект->Поручение", "Внимание!", MessageBoxButtons.OKCancel);
        }

        private void сделкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выбранно Объект->Сделка", "Внимание!", MessageBoxButtons.OKCancel);
        }

        private void должностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выбранно Справочник->Должность", "Внимание!", MessageBoxButtons.OKCancel);
        }

        private void странаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выбранно Справочник->Страна", "Внимание!", MessageBoxButtons.OKCancel);
        }

        private void регионToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выбранно Справочник->Регион", "Внимание!", MessageBoxButtons.OKCancel);
        }

        private void городToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выбранно Справочник->Город", "Внимание!", MessageBoxButtons.OKCancel);
        }

        private void иМНСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выбранно Справочник->ИМНС", "Внимание!", MessageBoxButtons.OKCancel);
           // toolStripStatusLabel1.Text = "Выбранно Справочник->ИМНС";
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа разработана \n" + "учащимся 2го курса группы ИВТ-21 \n" + "Суворовым Николаем", "Внимание!", MessageBoxButtons.OKCancel);
        }





        //хз какой блок
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
     
        }







        //блок с строкой статуса
        private void иМНСToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Выбранно Справочник->ИМНС";
        }

        private void иМНСToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void сотрудникToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Выбранно Объект->Сотрудник";
        }

        private void сотрудникToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void клиентToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Выбранно Объект->Клиент";
        }

        private void клиентToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void договорToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Выбранно Объект->Договор";
        }

        private void договорToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void поручениеToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Выбранно Объект->Поручение";
        }

        private void поручениеToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void сделкаToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Выбранно Объект->Сделка";
        }

        private void сделкаToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void выходToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "EXIT --> Закрыть приложение?";
        }

        private void выходToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void объектToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Выбранно Объект";
        }

        private void объектToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void справкаToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Выбранно Справочник";
        }

        private void справкаToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void должностьToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Выбранно Справочник->Должность";
        }

        private void должностьToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void странаToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Выбранно Справочник->Страна";
        }

        private void странаToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void регионToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Выбранно Справочник->Регион";

        }

        private void регионToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void городToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Выбранно Справочник->Город";
        }

        private void городToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void справкаToolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Коротко о программе и разработчике";
        }

        private void справкаToolStripMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void оПрограммеToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Выбранно Справка->О программе";
        }

        private void оПрограммеToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }



        //панель управления
        private void toolStripButton1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Панель управления->О программе";
        }

        private void toolStripButton1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void toolStripButton2_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Панель управления->Выход";
        }

        private void toolStripButton2_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
