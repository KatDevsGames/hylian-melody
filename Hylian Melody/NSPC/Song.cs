using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace HylianMelody.NSPC
{
    public class Song : ISerializable
    {
        [NotNull, ItemNotNull]
        public List<SongBlock> Blocks { get; } = new List<SongBlock>();

        [NotNull, ItemNotNull]
        public List<SongSegment> Segments { get; } = new List<SongSegment>();

        public ushort Offset { get; set; }

        private int? _size;
        public int Size
        {
            get
            {
                if (_size == null) { /*SetInternalPointers();*/ }
                // ReSharper disable once PossibleInvalidOperationException
                return (int)_size;
            }
        }

        public Song()
        {

        }

        public Song([NotNull] SerializationInfo info, StreamingContext context)
        {
            Blocks.AddRange((List<SongBlock>)info.GetValue("blocks", typeof(List<SongBlock>)));

            foreach (SongBlock block in Blocks)
            {
                if (block.BlockReference == null) { continue; }
                block.BlockReference = Blocks.FirstOrDefault(b => b.Equals(block.BlockReference));
            }

            Segments.AddRange((List<SongSegment>)info.GetValue("segments", typeof(List<SongSegment>)));

            Offset = info.GetUInt16("offset");
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("blocks", Blocks);
            info.AddValue("segments", Segments);
            info.AddValue("offset", Offset);
            //SetInternalPointers();
        }

        /***
            ; song list
            feff: dw $ffff,$a000,$a200,$a400,...
            ; block list of song $01 <-song
            a000: dw $b000
            a002: dw $b010
            a004: dw $0003,$b020 ; $0001-$007f - play for 4 (3+1) times
            a006: dw $00ff,$a002 ; $0080-$00ff - goto $a002 (loop)
            a008: dw $0000       ; end of song (shouldn't come here, though)
            ; block - starting point for each track ($00xx for null) <-song
            b000: dw $c000,$c100,$c200,$c300,$0000,$0000,$0000,$0000
            ; sequence
            c000: ; voice cmds to playback... <-phrase
        ***/

        //$1B804A - D046 - Hyrule Castle
        //76 D0 66 D0 86 D0 86 D0 96 D0 86 D0 A6 D0 B6 D0 D6 D0 E6 D0 C6 D0 F6 D0 06 D1 FF 00 4A D0 00 00

        public void LoadBytes([NotNull] Stream stream, long origin, ushort baseAddr)
        {
            long localOrigin = stream.Position;

            ushort nextAddr;
            do
            {
                long streamPos = stream.Position;
                nextAddr = stream.ReadSNESWord();
                if (nextAddr > baseAddr)
                {
                    SongSegment s = new SongSegment { Offset = (ushort)(nextAddr - baseAddr) };
                    stream.Position = origin + 4 + s.Offset;
                    s.LoadBytes(stream, origin, baseAddr);
                    Segments.Add(s);

                    SongBlock b = new SongBlock
                    {
                        Type = SongBlock.StatusType.Play,
                        Offset = (ushort)(streamPos - (origin + 4)),
                        SegmentReference = s
                    };
                    Blocks.Add(b);
                    stream.Position = streamPos + 2;
                }
                else if (nextAddr == 0xFF)
                {
                    nextAddr = stream.ReadSNESWord();
                    SongBlock b = new SongBlock
                    {
                        Type = SongBlock.StatusType.GoTo,
                        Offset = (ushort)(streamPos - (origin + 4)),//2=4(header)-2(read above)
                        BlockReference = Blocks.First(bl => bl.Offset == (nextAddr - baseAddr))
                    };
                    Blocks.Add(b);

                    stream.Position = streamPos + 4;
                }
                else if ((0 < nextAddr) && (nextAddr < 0xFF))
                {
                    ushort repeat = nextAddr;
                    nextAddr = stream.ReadSNESWord();
                    SongSegment s = new SongSegment { Offset = (ushort)(nextAddr - baseAddr) };
                    stream.Position = origin + 4 + s.Offset;
                    s.LoadBytes(stream, origin, baseAddr);
                    Segments.Add(s);

                    SongBlock b = new SongBlock
                    {
                        Type = SongBlock.StatusType.Repeat,
                        Offset = (ushort)(streamPos - (origin + 4)),
                        SegmentReference = s,
                        Loop = repeat
                    };
                    Blocks.Add(b);

                    stream.Position = streamPos + 4;
                }

            } while (nextAddr != 0);

            if (Segments.Count < 2) { return; }

            for (int i = 0; i < (Segments.Count - 1); i++)
            for (int j = i + 1; j < Segments.Count; j++) {
                Segments[i].ProcessOverlap(Segments[j]);
            }
        }

        public void SetInternalPointers(ref ushort offset)
        {
            Offset = offset;

            foreach (SongBlock b in Blocks)
            {
                b.Offset = offset;
                switch (b.Type)
                {
                    case SongBlock.StatusType.Play:
                        offset += 2;
                        continue;
                    case SongBlock.StatusType.Repeat:
                        offset += 4;
                        continue;
                    case SongBlock.StatusType.GoTo:
                        offset += 4;
                        continue;
                    case SongBlock.StatusType.Stop:
                        offset += 2;
                        continue;
                }
            }

            foreach (SongSegment s in Segments)
            {
                s.SetInternalPointers(ref offset);
            }

            _size = offset;
        }

        /***
            ; song list
            feff: dw $ffff,$a000,$a200,$a400,...
            ; block list of song $01 <-song
            a000: dw $b000
            a002: dw $b010
            a004: dw $0003,$b020 ; $0001-$007f - play for 4 (3+1) times
            a006: dw $00ff,$a002 ; $0080-$00ff - goto $a002 (loop)
            a008: dw $0000       ; end of song (shouldn't come here, though)
            ; block - starting point for each track ($00xx for null) <-song
            b000: dw $c000,$c100,$c200,$c300,$0000,$0000,$0000,$0000
            ; sequence
            c000: ; voice cmds to playback... <-phrase
        ***/

        //$1B804A - D046 - Hyrule Castle
        //76 D0 66 D0 86 D0 86 D0 96 D0 86 D0 A6 D0 B6 D0 D6 D0 E6 D0 C6 D0 F6 D0 06 D1 FF 00 4A D0 00 00

        public void WriteBytes([NotNull] Stream stream, ushort baseAddr)
        {
            foreach (SongBlock b in Blocks)
            {
                switch (b.Type)
                {
                    case SongBlock.StatusType.Play:
                        stream.WriteSNESWord(b.SegmentReference.Offset);
                        continue;
                    case SongBlock.StatusType.Repeat:
                        stream.Write(new byte[] { 0x00, (byte)b.Loop }, 0, 2);
                        stream.WriteSNESWord(b.SegmentReference.Offset);
                        continue;
                    case SongBlock.StatusType.GoTo:
                        stream.Write(new byte[] { 0x00, 0xFF }, 0, 2);
                        stream.WriteSNESWord(b.Offset);
                        continue;
                    case SongBlock.StatusType.Stop:
                        stream.WriteDoubleNull();
                        continue;
                }
            }

            foreach (SongSegment s in Segments)
            {
                s.WriteBytes(stream, baseAddr);
            }
        }
    }
}
