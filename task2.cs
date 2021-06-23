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
    public partial class task2 : Form
    {
        Random rand = new Random();
        int num_to_find;
        int total_tries = 0;
        public task2()
        {
            InitializeComponent();
            num_to_find = rand.Next(1, 2000);
        }

        private void send_Click(object sender, EventArgs e)
        {
            if (num_to_find == int.Parse(textBox1.Text))
            {
                MessageBox.Show($"You did it! {total_tries+1} tries.", textBox1.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                tryagain.Enabled = true;
            }
            else if (num_to_find < int.Parse(textBox1.Text))
            {
                MessageBox.Show("Your number is bigger...", textBox1.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                total_tries++;
            }
            else if (num_to_find > int.Parse(textBox1.Text))
            {
                MessageBox.Show("Your number is smaller...", textBox1.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                total_tries++;
            }
        }

        private void tryagain_Click(object sender, EventArgs e)
        {
            tryagain.Enabled = false;
            total_tries = 0;
            num_to_find = rand.Next(1, 2000);
            MessageBox.Show("Good Luck!");
        }
    }
}
