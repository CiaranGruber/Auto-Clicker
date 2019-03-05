using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoclicker
{
    public partial class TimerForm : Form
    {
        public int number = 5;

        public TimerForm()
        {
            InitializeComponent();
            Location = new Point(50, 50);
        }

        private void TimerForm_Shown(object sender, EventArgs e)
        {
            while (number > 0)
            {
                lbl_number.Text = number.ToString();
                Refresh();
                Thread.Sleep(1000);
                number--;
            }
            Close();
        }
    }
}
