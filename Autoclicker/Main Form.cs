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
    public partial class MainForm : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        public bool Clicking = false;

        public PointerForm PointerForm = new PointerForm();

        public LayoutCollection LayoutCollection = new LayoutCollection();
        
        public const int MOUSE_LEFTDOWN = 0x02;
        public const int MOUSE_LEFTUP = 0x04;
        public const int MOUSE_RIGHTDOWN = 0x08;
        public const int MOUSE_RIGHTUP = 0x10;

        public List<ClickerPosition> MousePositions = new List<ClickerPosition>();
        private System.Timers.Timer Timer = new System.Timers.Timer();

        public MainForm()
        {
            InitializeComponent();

            // Register the hotkey for clicking in specific places
            RegisterHotKey(Handle, 1, 0x0000, (int)Keys.F7);

            // Register the hotkey for clicking at the mouse
            RegisterHotKey(Handle, 2, 0x0000, (int)Keys.F8);
        }

        private void Autoclicker_Load(object sender, EventArgs e)
        {
            // Fix splitters
            splt_formSplitter.SplitterWidth = splt_formSplitter.Width / 20;
            splt_formSplitter.SplitterDistance = (splt_formSplitter.Width - splt_formSplitter.SplitterWidth) / 2;
            splt_tableTitle12Against3.SplitterDistance = splt_tableTitle12Against3.Width - 100;
            splt_tableTitle1Against2.SplitterDistance = 75;
            splt_coordinates.SplitterWidth = 5;
            splt_coordinates.SplitterDistance = (splt_coordinates.Width - splt_coordinates.SplitterWidth) / 2;

            // Set co-ordinate max range
            num_xValue.Maximum = 100000;
            num_yValue.Maximum = 100000;

            // Get available layouts
            cBo_layout.Items.AddRange(LayoutCollection.LayoutsAvailable.ToArray());
        }

        public void ClickMouseRepeatedly(bool atMouse)
        {
            // Set up timer
            Timer = new System.Timers.Timer();
            Timer.AutoReset = true;
            Timer.Enabled = true;
            Timer.Interval = 1000 / (int)num_clicksPerSecond.Value;

            // Choose specific methods depending on chosen option
            if (atMouse)
            {
                Timer.Elapsed += new System.Timers.ElapsedEventHandler(DoMouseClickAtMouse);
            }
            else
            {
                Timer.Elapsed += new System.Timers.ElapsedEventHandler(DoMouseClick);
            }
            Timer.Start();
        }

        public void DoMouseClick(object sender, EventArgs e)
        {
            // Keep original cursor position
            Point currentPosition = Cursor.Position;

            // Click in all given positions
            for (int i = 0; i < MousePositions.Count; i++)
            {
                Cursor.Position = new Point(MousePositions[i].X, MousePositions[i].Y);

                // Repeat clicks as required
                for (int x = 0; x < MousePositions[i].TimesToRepeat; x++)
                {
                    mouse_event(MOUSE_LEFTDOWN | MOUSE_LEFTUP, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                }
            }
            Cursor.Position = currentPosition;
        }

        public void DoMouseClickAtMouse(object sender, EventArgs e)
        {
            mouse_event(MOUSE_LEFTDOWN | MOUSE_LEFTUP, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
        }

        private void btn_clickAtMouse_Click(object sender, EventArgs e)
        {
            ClickMouseRepeatedly(true);
        }

        private void btn_clickParticularly_Click(object sender, EventArgs e)
        {
            ClickMouseRepeatedly(false);
        }

        private void btn_setCursorPosition_Click(object sender, EventArgs e)
        {
            // Show to form for the timer
            TimerForm timerForm = new TimerForm();
            timerForm.ShowDialog();

            // Set the values to the cursor position
            num_xValue.Value = Cursor.Position.X;
            num_yValue.Value = Cursor.Position.Y;
        }

        public void ToggleClicker(Keys keyPressed)
        {
            // Stop clicking if already clicking
            if (Clicking)
            {
                Timer.Dispose();
            }
            
            else if (keyPressed == Keys.F7)
            {
                ClickMouseRepeatedly(false);
            }
            else
            {
                ClickMouseRepeatedly(true);
            }
            Clicking = Clicking == false;
        }

        protected override void WndProc(ref Message m)
        {
            // Identify hotkey presses
            if (m.Msg == 0x0312)
            {
                // Get ID
                int id = m.WParam.ToInt32();

                // Choose specific option depending on ID
                if (id == 1)
                {
                    ToggleClicker(Keys.F7);
                }
                else if (id == 2)
                {
                    ToggleClicker(Keys.F8);
                }
            }

            base.WndProc(ref m);
        }

        private void btn_addValue_Click(object sender, EventArgs e)
        {
            // Add co-ordinate and update
            MousePositions.Add(new ClickerPosition((int)num_xValue.Value, (int)num_yValue.Value, 1));
            UpdateTable();
        }

        private void UpdateTable()
        {
            // Suspend layout to speed up processing
            tbl_xAndY.SuspendLayout();
            tbl_xAndY.Controls.Clear();

            // Get correct amount of rows plus one extra due to last row taking up more space than it should
            tbl_xAndY.RowCount = MousePositions.Count + 2;

            // Add headers
            tbl_xAndY.Controls.Add(new Label { Text = "X Values", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, AutoSize = false }, 1, 0);
            tbl_xAndY.Controls.Add(new Label { Text = "Y Values", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, AutoSize = false }, 2, 0);
            tbl_xAndY.Controls.Add(new Label { Text = "Repeats", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, AutoSize = false }, 3, 0);

            // Add positions
            for (int i = 0; i < MousePositions.Count; i++)
            {
                // Create re-organisation buttons
                DBLayoutPanel splitTable = new DBLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    Height = 20,
                    Margin = new Padding(0),
                    ColumnCount = 2,
                    RowCount = 1
                };
                splitTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                splitTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

                Button upButton = new Button
                {
                    Text = "↑",
                    Name = i.ToString(),
                    Dock = DockStyle.Fill,
                    Margin = new Padding(0)
                };
                upButton.Click += MoveUp;

                Button downButton = new Button
                {
                    Text = "↓",
                    Name = i.ToString(),
                    Dock = DockStyle.Fill,
                    Margin = new Padding(0)
                };
                downButton.Click += MoveDown;

                // Decide on which buttons to add
                if (i > 0)
                {
                    splitTable.Controls.Add(upButton, 0, 0);
                }
                if (i < MousePositions.Count - 1)
                {
                    splitTable.Controls.Add(downButton, 1, 0);
                }

                tbl_xAndY.Controls.Add(splitTable, 0, i + 1);
                
                // Add co-ordinate values
                tbl_xAndY.Controls.Add(new Label { Text = MousePositions[i].X.ToString(), TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill, AutoSize = false }, 1, i + 1);
                tbl_xAndY.Controls.Add(new Label { Text = MousePositions[i].Y.ToString(), TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill, AutoSize = false }, 2, i + 1);

                // Add repeats option
                NumericUpDown numericChoice = new NumericUpDown
                {
                    Value = MousePositions[i].TimesToRepeat,
                    Name = i.ToString(),
                    Minimum = 1,
                    Dock = DockStyle.Fill,
                    Margin = new Padding(0)
                };
                numericChoice.ValueChanged += ChangeRepeats;
                tbl_xAndY.Controls.Add(numericChoice, 3, i + 1);

                // Add delete button
                Button button = new Button
                {
                    Text = "Delete Value",
                    Name = i.ToString(),
                    Dock = DockStyle.Fill,
                    Margin = new Padding(0)
                };
                button.Click += DeletePosition;
                tbl_xAndY.Controls.Add(button, 4, i + 1);
            }
            
            // Update the view of the table (as all processing is complete)
            tbl_xAndY.ResumeLayout();
        }

        private void MoveDown(object sender, EventArgs e)
        {
            // Move position to the next in the list
            int currentIndex = Convert.ToInt32((sender as Control).Name);
            MousePositions.MoveItem(currentIndex, currentIndex + 1);
            UpdateTable();
        }

        private void MoveUp(object sender, EventArgs e)
        {
            // Move position up in the list
            int currentIndex = Convert.ToInt32((sender as Control).Name);
            MousePositions.MoveItem(currentIndex, currentIndex - 1);
            UpdateTable();
        }

        private void ChangeRepeats(object sender, EventArgs e)
        {
            // Change the number of times to repeat
            MousePositions[Convert.ToInt32((sender as Control).Name)].TimesToRepeat = (int)(sender as NumericUpDown).Value;
        }

        private void DeletePosition(object sender, EventArgs e)
        {
            // Delete the expected position and update
            MousePositions.RemoveAt(Convert.ToInt32((sender as Control).Name));
            UpdateTable();
        }

        private void num_xValue_Enter(object sender, EventArgs e)
        {
            // Show the crosshair on-screen
            PointerForm.Show();
            PointerForm.Location = new Point((int)num_xValue.Value - 25, (int)num_yValue.Value - 25);
        }

        private void num_xValue_ValueChanged(object sender, EventArgs e)
        {
            // Move crosshair
            PointerForm.Location = new Point((int)num_xValue.Value - 25, (int)num_yValue.Value - 25);
        }

        private void num_xValue_Leave(object sender, EventArgs e)
        {
            // Hide crosshair
            PointerForm.Hide();
        }

        private void num_yValue_Enter(object sender, EventArgs e)
        {
            // Show crosshair
            PointerForm.Show();
            PointerForm.Location = new Point((int)num_xValue.Value - 25, (int)num_yValue.Value - 25);
        }

        private void num_yValue_ValueChanged(object sender, EventArgs e)
        {
            // Move crosshair
            PointerForm.Location = new Point((int)num_xValue.Value - 25, (int)num_yValue.Value - 25);
        }

        private void num_yValue_Leave(object sender, EventArgs e)
        {
            // Hide crosshair
            PointerForm.Hide();
        }

        private void Autoclicker_Leave(object sender, EventArgs e)
        {
            // Hide crosshair
            PointerForm.Hide();
        }

        private void btn_saveLayout_Click(object sender, EventArgs e)
        {
            // Open layout form to get name
            using (AddLayoutForm layoutForm = new AddLayoutForm())
            {
                layoutForm.ShowDialog();

                // Save layout if OK is pressed
                if (layoutForm.DialogResult != DialogResult.Cancel)
                {
                    LayoutCollection.SaveLayout(new Layout(layoutForm.ResultingName, MousePositions));
                }
            }
            
            // Reset layout box
            cBo_layout.Items.Clear();
            cBo_layout.Items.AddRange(LayoutCollection.LayoutsAvailable.ToArray());
        }

        private void btn_delLayout_Click(object sender, EventArgs e)
        {
            // Remove layout if chosen
            if (cBo_layout.SelectedItem != null)
            {
                LayoutCollection.DeleteLayout(cBo_layout.SelectedItem.ToString());
                cBo_layout.SelectedItem = null;
            }

            // Update layout box
            cBo_layout.Items.Clear();
            cBo_layout.Items.AddRange(LayoutCollection.LayoutsAvailable.ToArray());
        }

        private void cBo_layout_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Change layout
            MousePositions = LayoutCollection.GetLayout(cBo_layout.SelectedItem.ToString()).Positions;
            UpdateTable();
        }
    }

    /// <summary>
    /// Contains extension methods required for the program to function
    /// </summary>
    public static class ExtraMethods
    {
        /// <summary>
        /// Moves an item from an old location to a new location
        /// </summary>
        /// <typeparam name="T">The list type</typeparam>
        /// <param name="list">The list to edit</param>
        /// <param name="oldIndex">The old index of the item</param>
        /// <param name="newIndex">The new index for the item to be placed at</param>
        public static void MoveItem<T>(this IList<T> list, int oldIndex, int newIndex)
        {
            T item = list[oldIndex];
            list.RemoveAt(oldIndex);
            list.Insert(newIndex, item);
        }
    }
}
