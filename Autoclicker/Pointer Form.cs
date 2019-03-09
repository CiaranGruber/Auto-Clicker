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
    public partial class PointerForm : Form
    {
        public PointerForm()
        {
            InitializeComponent();
            
            // Make background transparent
            TransparencyKey = Color.Turquoise;
            BackColor = Color.Turquoise;

            // Hide and don't show as another seperate form to the main form
            ShowInTaskbar = false;
            Hide();
        }

        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }
        
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x00000008;
                return createParams;
            }
        }
    }
}
