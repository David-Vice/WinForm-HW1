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
    public partial class task4 : Form
    {
        int X1 = 0;
        int X2 = 0;
        int Y1 = 0;
        int Y2 = 0;
        int num_button = 1;
        public task4()
        {
            InitializeComponent();
        }

        private void task4_MouseDown(object sender, MouseEventArgs e)
        {
            X1 = e.X;
            Y1 = e.Y;
        }

        private void task4_MouseUp(object sender, MouseEventArgs e)
        {
            X2 = e.X;
            Y2 = e.Y;

            int width = X2 - X1 > 0 ? X2 - X1 : X1 - X2;
            int height = Y2 - Y1 > 0 ? Y2 - Y1 : Y1 - Y2;

            if (height < 10 || width < 10)
            {
                MessageBox.Show("Min size is 10x10", "Wrong Size Of Button", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MyButton tmp = new MyButton();
            tmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            tmp.Name = "b" + num_button.ToString();
            tmp.Text = $"{num_button}";
            tmp.Size = new System.Drawing.Size(width, height);
            tmp.Location = new System.Drawing.Point(X1, Y1);
            tmp.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            tmp.UseVisualStyleBackColor = true;
            tmp.Click += new EventHandler(button_Click);
            tmp.DoubleClick += new EventHandler(button_DoubleClick);
            SetStyle(ControlStyles.StandardClick | ControlStyles.StandardDoubleClick, true);
            this.Controls.Add(tmp);
            num_button++;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if(enableDoubleClickToolStripMenuItem.Checked == true)
            MessageBox.Show($"Location: {(sender as MyButton).Location.X},{(sender as MyButton).Location.Y}\nSize: {(sender as MyButton).Size.Height}x{(sender as MyButton).Size.Width}");
        }

        private void button_DoubleClick(object sender, EventArgs e)
        {
            Controls.Remove(sender as MyButton);
        }

        private void enableDoubleClickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (enableDoubleClickToolStripMenuItem.Checked)
                enableDoubleClickToolStripMenuItem.Checked = false;
            else
                enableDoubleClickToolStripMenuItem.Checked = true;
        }
    }
}
