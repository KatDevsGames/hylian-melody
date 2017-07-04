using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HylianMelody
{
    public partial class SandboxWindow : Form
    {
        public SandboxWindow()
        {
            InitializeComponent();
        }

        private void SandboxWindow_Shown(object sender, EventArgs e)
        {
            nspcTracker1.Invalidate();
        }
    }
}
