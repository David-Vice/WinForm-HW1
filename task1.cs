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
    public partial class task1 : Form
    {
        public task1()
        {
            InitializeComponent();
        }

        private void task1_Shown(object sender, EventArgs e)
        {
            MessageBox.Show($"Symbols: {textBox1.Text.Length}");
        }
    }
}
