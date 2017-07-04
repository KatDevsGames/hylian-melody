using System;
using System.IO;
using HylianMelody.NSPC;
using Sanford.Multimedia.Midi;
using Track = HylianMelody.NSPC.Track;

namespace HylianMelody.MIDI
{
    public class MidiReader
    {
        private const int TRACKS_PER_SEGMENT = 8;

        private readonly ChannelMessage[] _last_on = new ChannelMessage[TRACKS_PER_SEGMENT];

        public Song Read(Stream stream)
        {
            Sequence seq = new Sequence(stream);

            int i = 0;
            SongSegment segment = new SongSegment();
            foreach (Sanford.Multimedia.Midi.Track track in seq)
            {
                Track nTrack = new Track();
                foreach (MidiEvent e in track.Iterator())
                {
                    switch (e.MidiMessage.MessageType)
                    {
                        case MessageType.Channel:
                            nTrack.Commands.Add(Convert((ChannelMessage) e.MidiMessage));
                            break;
                        case MessageType.SystemExclusive:
                            break;
                        case MessageType.SystemCommon:
                            break;
                        case MessageType.SystemRealtime:
                            break;
                        case MessageType.Meta:
                            break;
                        case MessageType.Short:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }

                segment.Tracks[i] = nTrack;
                i++;
                if (i >= TRACKS_PER_SEGMENT) { break; }
            }

            SongBlock block = new SongBlock
            {
                SegmentReference = segment,
                Type = SongBlock.StatusType.Play
            };

            Song song = new Song();
            song.Blocks.Add(block);
            song.Blocks.Add(SongBlock.StopBlock);
            song.Segments.Add(segment);
            return song;
        }

        private Command Convert(ChannelMessage message)
        {
            Command result = null;
            switch (message.Command)
            {
                case ChannelCommand.NoteOff:
                    break;
                case ChannelCommand.NoteOn:
                    //result = GetNote(message);
                    break;
                case ChannelCommand.PolyPressure:
                    break;
                case ChannelCommand.Controller:
                    break;
                case ChannelCommand.ProgramChange:
                    result = new Command(Command.CommandValue.SetInstrument);
                    result.Parameters[0] = (byte) message.Data1;
                    break;
                case ChannelCommand.ChannelPressure:
                    break;
                case ChannelCommand.PitchWheel:
                    //result = new Command(Command.CommandValue.PitchSlide);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return result;
        }

        /**
         *  C   C#  D   D#  E   F   F#  G   G#  A   A#  B
         *  24	25	26	27	28	29	30	31	32	33	34	35
         *  36	37	38	39	40	41	42	43	44	45	46	47
         *  48	49	50	51	52	53	54	55	56	57	58	59
         *  60	61	62	63	64	65	66	67	68	69	70	71
         *  72	73	74	75	76	77	78	79	80	81	82	83
         *  84	85	86	87	88	89	90	91	92	93	94	95
         **/

        public Command[] GetNote(ChannelMessage message)
        {

            if ((message.Data1 < 24) || (message.Data1 > 95)) { throw new ArgumentOutOfRangeException(); }
            Command note = new Command((Command.CommandValue) ((message.Data1 - 24) + 0x80));
            byte b = (byte) (0x70 + ((message.Data2 / 127f) * 15));
            //Command parameter 
            return new []{note};
        }
    }
}
