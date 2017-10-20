using System.Collections.Generic;
using System.IO;
using System.Linq;
using JetBrains.Annotations;

namespace HylianMelody.NSPC
{
    public class SongBank
    {
        [NotNull, ItemCanBeNull]
        public List<Song> Songs { get; } = new List<Song>();

        private ushort _size = 0;
        private ushort _base = 0xD000;

        public SongBank() { }

        public SongBank([NotNull] Stream stream, int songCount) { LoadBytes(stream, songCount); }

        //$1B8000 + 31D6
        //BF 2C (Bank Size $2CBF)
        //00 D0 (Base Address $D000)

        //BASE $D000
        //$1B8004
        //00 00 00 00  00 00 00 00
        //00 00 00 00  00 00 00 00
        //00 00 00 00  80 28 00 00
        //00 00 00 00  00 00 46 D0 <- Hyrule Castle
        //EC DB 3A E1  31 E4 F9 E6
        //1E E9 0B EC  D1 F1 3A E1
        //04 F3 80 F5  09 F9 6A FB
        //00 2B 59 2F  B3 2B 00 00 (B3 2B = Ganon Battle)
        //00 2B 59 2F  B3 2B

        //$1B804A - D046 - Hyrule Castle
        //76 D0 66 D0 86 D0 86 D0 96 D0 86 D0 A6 D0 B6 D0 D6 D0 E6 D0 C6 D0 F6 D0 06 D1 FF 00 4A D0 00 00

        public void SeekStream(Stream stream, ushort offset)
        {
            stream.Position = (offset - _base) + 4;
        }

        public byte[] ToBytes()
        {
            MemoryStream stream = new MemoryStream();
            WriteBytes(stream);
            return stream.ToBytes();
        }

        public void SetInternalPointers()
        {
            ushort offset = (ushort)(Songs.Count * 2);
            foreach (Song s in Songs)
            {
                if (s == null)
                {
                    offset += 2;
                    continue;
                }
                s.SetInternalPointers(ref offset);
            }
            _size = (ushort) (offset - 4);
        }

        public void WriteBytes([NotNull] Stream stream)
        {
            SetInternalPointers();

            stream.WriteSNESWord(_size); // mystery bytes
            stream.WriteSNESWord(_base); // base address
            foreach (Song s in Songs)
            {
                if (s == null)
                {
                    stream.WriteDoubleNull();
                    continue;
                }
                stream.WriteSNESWord((ushort) (s.Offset + _base));
            }
            foreach (Song s in Songs.Where(s => s != null))
            {
                s.WriteBytes(stream, _base);
            }
        }

        public void LoadBytes([NotNull] Stream stream, int songCount)
        {
            long origin = stream.Position;

            stream.Seek(2, SeekOrigin.Current); //skip initial 2 bytes, we don't know what they do

            _base = stream.ReadSNESWord();
            
            for (int i = 0; i < songCount; i++)
            {
                ushort nextAddr = stream.ReadSNESWord();
                if ((nextAddr == 0) || (nextAddr < _base))
                {
                    Songs.Add(null);
                    continue;
                }
                Songs.Add(new Song { Offset = (ushort)(nextAddr - _base) });
            }

            foreach (Song s in Songs)
            {
                if (s == null) { continue; }
                stream.Position = origin + s.Offset + 4;
                s.LoadBytes(stream, origin, _base, this);
            }
        }
    }
}
