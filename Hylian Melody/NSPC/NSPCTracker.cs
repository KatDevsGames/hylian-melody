using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace HylianMelody.NSPC
{
    public partial class NSPCTracker : Control
    {
        private const int ROW_HEIGHT = 32;

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

        private Point _hover = Point.Empty;

        private Point _selected = Point.Empty;

        private Command SelectedCommand
        {
            [DebuggerStepThrough]
            get
            {
                try { return _segment.Tracks[_selected.X].Commands[_selected.Y]; }
                catch { return null; }
            }
        }

        private const int TRACKS_PER_SEGMENT = 8;

        private bool _dragging = false;

        private SongSegment _segment;

        private Song _song;

        public NSPCTracker()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        public void Load(SongSegment songSegment, Song song)
        {
            _segment = songSegment;
            _song = song;
            ITrack[] tracks = _segment.Tracks;
            for (int i = 0; i < TRACKS_PER_SEGMENT; i++)
            {
                _max_height = Math.Max(_max_height, tracks[i].Commands.Count);
            }
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if ((e.Button == MouseButtons.Left) || (e.Button == MouseButtons.Right))
            {
                float eigthWidth = Width / 8f;
                _selected = new Point((int)(e.X / eigthWidth), (e.Y / ROW_HEIGHT) + ((int)(_max_height * _scroll)));
            }
            if (e.Button == MouseButtons.Right)
            {
                (new ContextCommand(_selected, _segment, _song, this, SelectedCommand != null)).Show(this, e.Location);
            }
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (_dragging)
            {
                if (_segment.Tracks[_selected.X].Commands.Count > _selected.Y)
                {
                    _segment.Tracks[_hover.X].Commands.Insert(_hover.Y, _segment.Tracks[_selected.X].Commands[_selected.Y]);
                    _segment.Tracks[_selected.X].Commands.RemoveAt(_selected.Y);
                }
            }
            _dragging = false;
            _hover = new Point(-1, -1);
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                _dragging = true;
                float eigthWidth = Width / 8f;
                _hover = new Point((int)(e.X / eigthWidth), (e.Y / ROW_HEIGHT) + ((int)(_max_height * _scroll)));
                Invalidate();
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _dragging = false;
            _hover = new Point(-1, -1);
            Invalidate();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);
            float eigthWidth = Width / 8f;
            _selected = new Point((int)(e.X / eigthWidth), (e.Y / ROW_HEIGHT) + ((int)(_max_height * _scroll)));

            if (SelectedCommand == null) { return; }
            _segment.Tracks[_selected.X].Commands[_selected.Y] = CommandEditor.Edit(SelectedCommand, _song);

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
            ITrack[] tracks = _segment.Tracks;
            float eigthWidth = Width / 8f;
            Font captionFont = new Font(FontFamily.GenericMonospace, 8, FontStyle.Bold);

            for (int i = 0; i < TRACKS_PER_SEGMENT; i++)
            {
                g.FillRectangle(((i % 2) == 0) ? Brushes.Gray : Brushes.DarkGray, i * eigthWidth, 0, eigthWidth, Height);
            }
            for (int i = 0; (i * ROW_HEIGHT) < Height; i++)
            {
                g.DrawLine(Pens.Black, 0, i * ROW_HEIGHT, Width, i * ROW_HEIGHT);
            }

            if (_segment == null) { return; }
            for (int i = 0; i < TRACKS_PER_SEGMENT; i++)
            {
                ITrack track = tracks[i];
                if (track == null) { continue; }
                List<Command> commands = track.Commands;
                for (int j = (int)(_max_height * _scroll), k = 0; ((k * ROW_HEIGHT) < Height) && (j < commands.Count); j++, k++)
                {
                    g.DrawString(commands[j].ToString(), captionFont, Brushes.Black, (i * eigthWidth), (k * ROW_HEIGHT));
                    if ((i == _selected.X) && (j == _selected.Y))
                    {
                        g.DrawRectangle(Pens.Red, (i * eigthWidth), (k * ROW_HEIGHT), eigthWidth, ROW_HEIGHT);
                    }
                    if ((i == _hover.X) && (j == _hover.Y))
                    {
                        g.DrawRectangle(Pens.Green, (i * eigthWidth), (k * ROW_HEIGHT), eigthWidth, ROW_HEIGHT);
                    }
                }
            }
        }
    }
}
