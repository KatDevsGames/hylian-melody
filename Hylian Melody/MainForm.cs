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

        private TrackEditor[] _editors;

        public MainForm()
        {
            InitializeComponent();

            _editors = new[]
            {
                trackEditor1,
                trackEditor2,
                trackEditor3,
                trackEditor4,
                trackEditor5,
                trackEditor6,
                trackEditor7,
                trackEditor8
            };
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
            listSegments.Items.AddRange(song.Segments.ToArray());
        }

        private void LoadSegment(SongSegment segment)
        {
            for (int i = 0; i < 8; i++)
            {
                _editors[i].LoadTrack(segment.Tracks[i], i);
            }
        }

        private void buttonSegmentAdd_Click(object sender, EventArgs e)
        {
            listSegments.Items.Add(new SongSegment());
        }

        private void buttonSegmentRemove_Click(object sender, EventArgs e)
        {
            listSegments.Items.Remove(listSegments.SelectedItem);
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
    }
}
