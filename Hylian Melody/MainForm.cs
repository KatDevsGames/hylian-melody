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

        private Song _song;

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
            listSubroutines.Items.Clear();
            if (song == null) { return; }
            listSegments.Items.AddRange(song.Segments.ToArray());
            listSubroutines.Items.AddRange(song.Subroutines.ToArray());
            if (listSegments.Items.Count > 0) { listSegments.SelectedIndex = 0; }
            _song = song;
        }

        private void LoadSegment(SongSegment segment)
        {
            /*for (int i = 0; i < 8; i++)
            {
                _editors[i].LoadTrack(segment.Tracks[i], i);
            }*/
            nspcTracker.Load(segment, _song);
        }

        private void buttonSongAdd_Click(object sender, EventArgs e)
        {
            _bank.Songs.Add(new Song());
            PrepGUI();
        }

        private void buttonSongRemove_Click(object sender, EventArgs e)
        {
            if (listSongs.SelectedItem == null) { return; }
            _bank.Songs.Remove((Song) listSongs.SelectedItem);
            PrepGUI();
        }

        private void buttonSegmentAdd_Click(object sender, EventArgs e)
        {
            _song.Segments.Add(new SongSegment());
            LoadSong(_song);
        }

        private void buttonSegmentRemove_Click(object sender, EventArgs e)
        {
            if (listSegments.SelectedItem == null) { return; }
            _song.Segments.Remove((SongSegment)listSegments.SelectedItem);
            LoadSong(_song);
        }

        private void buttonSubroutineAdd_Click(object sender, EventArgs e)
        {
            _song.Subroutines.Add(new Track());
            LoadSong(_song);
        }

        private void buttonSubroutineRemove_Click(object sender, EventArgs e)
        {
            if (listSubroutines.SelectedItem == null) { return; }
            _song.Subroutines.Remove((Track)listSubroutines.SelectedItem);
            LoadSong(_song);
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

        private void listSubroutines_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
            => nspcTracker.Scroll = vScrollBar.Value / ((float)vScrollBar.Maximum);

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listSegments.Items.Clear();
            listSongs.Items.Clear();
        }
    }
}
