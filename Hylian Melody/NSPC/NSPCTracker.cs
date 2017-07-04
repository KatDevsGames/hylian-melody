using System.Drawing;
using System.Windows.Forms;

namespace HylianMelody.NSPC
{
    public partial class NSPCTracker : Control
    {
        private const int TRACKS_PER_SEGMENT = 8;

        private SongSegment _segment;

        public NSPCTracker()
        {
            InitializeComponent();
        }

        public void Load(SongSegment songSegment)
        {
            _segment = songSegment;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            //base.OnPaint(pe);
            const int rowHeight = 32;

            Graphics g = pe.Graphics;
            float eigthWidth = Width / 8f;
            for (int i = 0; i < TRACKS_PER_SEGMENT; i++)
            {
                g.FillRectangle(((i % 2) == 0) ? Brushes.Gray : Brushes.DarkGray, i * eigthWidth, 0, eigthWidth, Height);
            }
            for (int i = 0; (i * rowHeight) < Height; i++)
            {
                g.DrawLine(Pens.Black, 0, i * rowHeight, Width, i * rowHeight);
            }
        }
    }
}
