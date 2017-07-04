using System;
using System.Windows.Forms;
using HylianMelody.NSPC;

namespace HylianMelody
{
    public partial class TrackEditor : UserControl
    {
        private ITrack _track;
        private int _track_number = -1;

        public TrackEditor()
        {
            InitializeComponent();
        }

        public event EventHandler<int> OnPlayTrack;
        public event EventHandler OnPlayAll;

        public void LoadTrack(ITrack track, int trackNumber)
        {
            ClearTrack();
            if (track == null) { return; }
            _track = track;
            _track_number = trackNumber;

            listCommands.Items.AddRange(_track.Commands.ToArray());
        }

        public void ClearTrack()
        {
            _track = null;
            _track_number = -1;
            listCommands.Items.Clear();
        }
    }
}
