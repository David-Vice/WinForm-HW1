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
    public partial class task5 : Form
    {
        public task5()
        {
            InitializeComponent();
        }

        private void joke_MouseMove(object sender, MouseEventArgs e)
        {
            joke.Top -= e.Y;
            joke.Left += e.X;
            if (joke.Top < -10 || joke.Top > 100)
            {
                joke.Top = 60;
            }
            if (joke.Left < -80 || joke.Left > 250)
            {
                joke.Left = 120;
            }
        }
    }
}
