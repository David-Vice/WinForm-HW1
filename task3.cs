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
    public partial class task3 : Form
    {
        public task3()
        {
            InitializeComponent();
            this.MinimumSize = new Size(800, 600);
            this.MaximumSize = new Size(800, 600);


        }

        private void task3_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show($"Mouse is not on the image!\nWindow size: X:{this.ClientSize.Width} Y:{this.ClientSize.Height}");
        }
       
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show($"Mouse is on the image!\nWindow size: X:{this.ClientSize.Width} Y:{this.ClientSize.Height}");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void task3_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X:{e.X} Y:{e.Y}";
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X:{e.X} Y:{e.Y}";
        }
    }
}
