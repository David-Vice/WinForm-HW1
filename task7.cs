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
    public partial class task7 : Form
    {
        public task7()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime dt1 = new DateTime();
            MessageBox.Show($"Time Remains\nDays: {monthCalendar1.SelectionStart.DayOfYear-DateTime.Now.DayOfYear}");
        }
    }
}
