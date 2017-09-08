using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using HylianMelody.NSPC;

namespace HylianMelody
{
    public partial class MainForm : Form
    {
        private SongBank _bank;

        public MainForm()
        {
            InitializeComponent();
        }

        private void PrepGUI()
        {
            Invoke(new Action(() =>
            {
                listSongs.Items.Clear();
                listSongs.Items.AddRange(_bank.Songs.Where(s=>(s!=null)).ToArray());
            }));
        }

        private void LoadSong(Song song)
        {
            listSegments.Items.Clear();
            if (song == null) { return; }
            listSegments.Items.AddRange(song.Segments.ToArray());
            if (listSegments.Items.Count > 0) { listSegments.SelectedIndex = 0; }
        }

        private void LoadSegment(SongSegment segment)
        {
            /*for (int i = 0; i < 8; i++)
            {
                _editors[i].LoadTrack(segment.Tracks[i], i);
            }*/
            nspcTracker.Load(segment);
        }

        private void buttonSegmentAdd_Click(object sender, EventArgs e)
        {
            listSegments.Items.Add(new SongSegment());
        }

        private void buttonSegmentRemove_Click(object sender, EventArgs e)
        {
            if (listSegments.SelectedItem == null) { return; }
            listSegments.Items.Remove(listSegments.SelectedItem);
        }

        private void buttonSongAdd_Click(object sender, EventArgs e)
        {
            listSongs.Items.Add(new Song());
        }

        private void buttonSongRemove_Click(object sender, EventArgs e)
        {
            if (listSongs.SelectedItem == null) { return; }
            listSongs.Items.Remove(listSongs.SelectedItem);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                        stream.Position = (long) ev2;
                        _bank = new SongBank(stream, 35);
                    }
                    PrepGUI();
                };
                n.ShowDialog();
            };
            od.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog
            {
                DefaultExt = "sfc",
                Filter = @"SNES ROM Image (*.sfc)|*.sfc"
            };
            sd.FileOk += (s, ev) =>
            {
                NumericDialog n = new NumericDialog("Select Offset", 0xD8000);
                n.OnOK += (s2, ev2) =>
                {
                    using (Stream stream = File.Open(sd.FileName, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        stream.Position = (long)ev2;
                        _bank.WriteBytes(stream);
                    }
                };
                n.ShowDialog();
            };
            sd.ShowDialog();
        }

        private void listSongs_SelectedIndexChanged(object sender, EventArgs e)
            => LoadSong((Song)listSongs.SelectedItem);

        private void listSegments_SelectedIndexChanged(object sender, EventArgs e)
            => LoadSegment((SongSegment)listSegments.SelectedItem);

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
            => nspcTracker.Scroll = vScrollBar.Value / ((float)vScrollBar.Maximum);

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listSegments.Items.Clear();
            listSongs.Items.Clear();
        }
    }
}
