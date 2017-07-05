using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HylianMelody.NSPC
{
    public partial class NSPCTracker : Control
    {
        private int _max_height = 0;
        public int MaxHeight => _max_height;

        private float _scroll = 0;
        public float Scroll
        {
            get => _scroll;
            set
            {
                if (value < 0) { value = 0; }
                else if (value > 1) { value = 1; }
                _scroll = value;
                Invalidate();
            }
        }

        private const int TRACKS_PER_SEGMENT = 8;

        private SongSegment _segment;

        public NSPCTracker()
        {
            InitializeComponent();
        }

        public void Load(SongSegment songSegment)
        {
            _segment = songSegment;
            ITrack[] tracks = _segment.Tracks;
            for (int i = 0; i < TRACKS_PER_SEGMENT; i++)
            {
                _max_height = Math.Max(_max_height, tracks[i].Commands.Count);
            }
            Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            Graphics g = pe.Graphics;
            if (_segment == null)
            {
                g.FillRectangle(Brushes.Gray, 0, 0, Width, Height);
                return;
            }
            //base.OnPaint(pe);
            const int rowHeight = 32;
            ITrack[] tracks = _segment.Tracks;
            float eigthWidth = Width / 8f;

            for (int i = 0; i < TRACKS_PER_SEGMENT; i++)
            {
                g.FillRectangle(((i % 2) == 0) ? Brushes.Gray : Brushes.DarkGray, i * eigthWidth, 0, eigthWidth, Height);
            }
            for (int i = 0; (i * rowHeight) < Height; i++)
            {
                g.DrawLine(Pens.Black, 0, i * rowHeight, Width, i * rowHeight);
            }
            
            if (_segment == null) { return; }
            for (int i = 0; i < TRACKS_PER_SEGMENT; i++)
            {
                ITrack track = tracks[i];
                if (track == null) { continue; }
                List<Command> commands = track.Commands;
                for (int j = (int)(_max_height * _scroll), k = 0; ((k * rowHeight) < Height) && (j < commands.Count); j++, k++)
                {
                    g.DrawString(commands[j].ToString(), new Font(FontFamily.GenericMonospace, 8, FontStyle.Bold), Brushes.Black, i * eigthWidth, k * rowHeight);
                }
            }
        }
    }
}
