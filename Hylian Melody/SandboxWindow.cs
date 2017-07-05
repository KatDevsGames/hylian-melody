using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HylianMelody.NSPC;

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
            SongBank bank=null;
            OpenFileDialog od = new OpenFileDialog
            {
                DefaultExt = "sfc",
                Filter = @"SNES ROM Image (*.sfc)|*.sfc",
                Multiselect = false
            };
            od.FileOk += (s, ev) =>
            {
                NumericDialog n = new NumericDialog("Select Offset", 0xD8000);
                n.OnOK += (s2, ev2) =>
                {
                    using (Stream stream = File.OpenRead(od.FileName))
                    {
                        stream.Position = (long)ev2;
                        bank = new SongBank(stream, 35);
                    }
                };
                n.ShowDialog();
            };
            od.ShowDialog();
            if (bank == null) { return; }
            nspcTracker.Load(bank.Songs[15].Segments[0]);
            vScrollBar.Maximum = nspcTracker.MaxHeight;
        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            nspcTracker.Scroll = vScrollBar.Value / ((float)vScrollBar.Maximum);
        }
    }
}
