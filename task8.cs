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
    public partial class task8 : Form
    {
        public task8()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==0) textBox1.Text = "1.20";
            else if (comboBox1.SelectedIndex == 1) textBox1.Text = "1.50";
            else if (comboBox1.SelectedIndex == 2) textBox1.Text = "1.80";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                textBox2.Enabled = true;
                textBox3.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox2.Enabled = false;
                textBox3.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label6.Text = (float.Parse(textBox1.Text) * float.Parse(textBox2.Text)).ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label6.Text = textBox3.Text;
        }

        private void label9_TextChanged(object sender, EventArgs e)
        {
            label10.Text = (float.Parse(label9.Text) + float.Parse(label6.Text)).ToString();
        }

        private void label6_TextChanged(object sender, EventArgs e)
        {
            label10.Text = (float.Parse(label9.Text) + float.Parse(label6.Text)).ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) textBox9.Enabled = true;
            else textBox9.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) textBox8.Enabled = true;
            else textBox8.Enabled = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) textBox10.Enabled = true;
            else textBox10.Enabled = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) textBox11.Enabled = true;
            else textBox11.Enabled = false;
        }

        private void count_TextChanged(object sender, EventArgs e)
        {
            label9.Text = "0";

            if (textBox8.Enabled && textBox8.Text.Length>0) label9.Text = (float.Parse(label9.Text) + float.Parse(textBox8.Text) * float.Parse(textBox7.Text)).ToString();
            if (textBox9.Enabled && textBox9.Text.Length > 0) label9.Text = (float.Parse(label9.Text) + float.Parse(textBox9.Text) * float.Parse(textBox4.Text)).ToString();
            if (textBox10.Enabled && textBox10.Text.Length > 0) label9.Text = (float.Parse(label9.Text) + float.Parse(textBox10.Text) * float.Parse(textBox6.Text)).ToString();
            if (textBox11.Enabled && textBox11.Text.Length > 0) label9.Text = (float.Parse(label9.Text) + float.Parse(textBox11.Text) * float.Parse(textBox5.Text)).ToString();
        }
    }
}
