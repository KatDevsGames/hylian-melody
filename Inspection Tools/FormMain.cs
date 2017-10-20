using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inspection_Tools
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog
            {
                CheckFileExists = true,
                Filter = @"Super Famicom ROM (*.sfc)|*.sfc|Super Famicom SRAM (*.srm)|*.srm|All Files (*.*)|*.*"
            };
            od.ShowDialog(this);
        }
    }
}
