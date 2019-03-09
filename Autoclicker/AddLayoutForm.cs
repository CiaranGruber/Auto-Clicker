using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoclicker
{
    public partial class AddLayoutForm : Form
    {
        public string ResultingName;

        public AddLayoutForm()
        {
            InitializeComponent();

            // Make the default result 'Cancel'
            DialogResult = DialogResult.Cancel;
            
            // Fix Split Containers
            splitContainer1.SplitterWidth = 2;
            splitContainer1.SplitterDistance = (splitContainer1.Width - splitContainer1.SplitterWidth) / 2;

            // Treat as non-separate form
            ShowInTaskbar = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // Set return value (resulting name) to given text and close with OK DialogResult
            ResultingName = txt_layoutName.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void txt_layoutName_TextChanged(object sender, EventArgs e)
        {
            // Only allow saving of name if name is entered
            btn_save.Enabled = txt_layoutName.Text.Length > 0;
        }
    }
}
