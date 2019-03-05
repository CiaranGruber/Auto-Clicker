using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace Autoclicker
{
    public partial class Autoclicker : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        public const int MOUSE_LEFTDOWN = 0x02;
        public const int MOUSE_LEFTUP = 0x04;
        public const int MOUSE_RIGHTDOWN = 0x08;
        public const int MOUSE_RIGHTUP = 0x10;

        private uint xValue;
        private uint yValue;
        private System.Timers.Timer Timer = new System.Timers.Timer();

        public Autoclicker()
        {
            InitializeComponent();
        }

        private void Autoclicker_Load(object sender, EventArgs e)
        {
            splitContainer1.SplitterWidth = splitContainer1.Width / 20;
            splitContainer1.SplitterDistance = (splitContainer1.Width - splitContainer1.SplitterWidth) / 2;
            num_xValue.Maximum = Screen.PrimaryScreen.WorkingArea.Width;
            num_yValue.Maximum = Screen.PrimaryScreen.WorkingArea.Height;
        }

        public void ClickMouseRepeatedly()
        {
            Timer.AutoReset = true;
            Timer.Enabled = true;
            Timer.Interval = 1000 / (int)num_clicksPerSecond.Value;
            Timer.Elapsed += new System.Timers.ElapsedEventHandler(DoMouseClickAtMouse);
            Timer.Start();
        }

        public void ClickMouseRepeatedly(uint x, uint y)
        {
            xValue = x;
            yValue = y;
            Timer.AutoReset = true;
            Timer.Enabled = true;
            Timer.Interval = 1000 / (int)num_clicksPerSecond.Value;
            Timer.Elapsed += new System.Timers.ElapsedEventHandler(DoMouseClick);
            Timer.Start();
        }

        public void DoMouseClick(object sender, EventArgs e)
        {
            mouse_event(MOUSE_LEFTDOWN | MOUSE_LEFTUP, xValue, yValue, 0, 0);
        }

        public void DoMouseClickAtMouse(object sender, EventArgs e)
        {
            mouse_event(MOUSE_LEFTDOWN | MOUSE_LEFTUP, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
        }

        private void btn_clickAtMouse_Click(object sender, EventArgs e)
        {
            ClickMouseRepeatedly();
        }

        private void btn_clickParticularly_Click(object sender, EventArgs e)
        {
            ClickMouseRepeatedly((uint)num_xValue.Value, (uint)num_yValue.Value);
        }

        private void btn_setCursorPosition_Click(object sender, EventArgs e)
        {
            TimerForm timerForm = new TimerForm();
            timerForm.ShowDialog();
            num_xValue.Value = Cursor.Position.X;
            num_yValue.Value = Cursor.Position.Y;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.NumPad0))
            {
                ClickMouseRepeatedly();
            }
            else if (keyData == (Keys.Control | Keys.NumPad1))
            {
                ClickMouseRepeatedly((uint)num_xValue.Value, (uint)num_yValue.Value);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
