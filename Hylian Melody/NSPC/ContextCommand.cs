using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JetBrains.Annotations;

namespace HylianMelody.NSPC
{
    class ContextCommand : ContextMenuStrip
    {
        private Command SelectedCommand
            => _segment.Tracks[_selected.X].Commands[_selected.Y];

        private Point _selected;

        private SongSegment _segment;

        private Song _song;

        private NSPCTracker _tracker;

        public ContextCommand() : base() { }

        public ContextCommand(Point selected, SongSegment segment, Song song, NSPCTracker tracker, bool create = false) : this()
        {
            _selected = selected;
            _segment = segment;
            _song = song;
            _tracker = tracker;

            if (create)
            {
                Items.Add(SelectedCommand.ToString());

                Items.Add("-");

                Items.Add("Edit", null, (sender, e) =>
                {
                    _segment.Tracks[_selected.X].Commands[_selected.Y] = CommandEditor.Edit(SelectedCommand, _song);
                    _tracker.Invalidate();
                });

                Items.Add("Delete", null, (sender, e) =>
                {
                    _segment.Tracks[_selected.X].Commands.RemoveAt(_selected.Y);
                    _tracker.Invalidate();
                });

                Items.Add("-");

                Items.Add("Insert Above", null, (sender, e) =>
                {
                    _segment.Tracks[_selected.X].Commands.Insert(Math.Min(_selected.Y, _segment.Tracks[_selected.X].Commands.Count), CommandEditor.Edit());
                    _tracker.Invalidate();
                });
            }

            Items.Add("Insert Below", null, (sender, e) =>
            {
                _segment.Tracks[_selected.X].Commands.Insert(Math.Min(_selected.Y + 1, _segment.Tracks[_selected.X].Commands.Count), CommandEditor.Edit());
                _tracker.Invalidate();
            });
        }
    }
}
