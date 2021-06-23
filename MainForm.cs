using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_HW1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            task1 t1 = new task1();
            t1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            task2 t2 = new task2();
            t2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            task3 t3 = new task3();
            t3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            task4 t4 = new task4();
            t4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            task5 t5 = new task5();
            t5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            task6 t6 = new task6();
            t6.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            task7 t7 = new task7();
            t7.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            task8 t8 = new task8();
            t8.ShowDialog();
        }
    }
}
