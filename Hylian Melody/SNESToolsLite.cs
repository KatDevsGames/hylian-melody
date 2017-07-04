using System.IO;
using JetBrains.Annotations;

namespace HylianMelody
{
    public static class SNESToolsLite
    {
        [NotNull]
        public static byte[] ToSNES(this ushort value)
        {
            byte[] bytes = new byte[2];
            bytes[0] = (byte)(value);
            bytes[1] = (byte)(value >> 8);
            return bytes;
        }

        public static ushort FromSNES([NotNull] this byte[] value)
        {
            return (ushort) (value[0] + (value[1]*256));
        }

        public static void WriteSNESWord([NotNull] this Stream stream, ushort value)
        {
            byte[] bytes = value.ToSNES();
            stream.Write(bytes, 0, 2);
        }

        public static ushort ReadSNESWord([NotNull] this Stream stream)
        {
            byte[] bytes = new byte[2];
            stream.Read(bytes, 0, 2);
            return bytes.FromSNES();
        }

        public static byte? ActuallyReadByte([NotNull] this Stream stream)
        {
            int clearlyNotAByte = stream.ReadByte();
            if (clearlyNotAByte == -1) { return null; }
            return (byte) clearlyNotAByte;
        }

        public static byte Peek([NotNull] this Stream stream)
        {
            byte result = stream.ActuallyReadByte()??throw new EndOfStreamException();
            stream.Seek(-1, SeekOrigin.Current);
            return result;
        }

        [NotNull]
        public static byte[] ToBytes([NotNull] this Stream stream)
        {
            byte[] result = new byte[stream.Length];
            stream.Position = 0;
            stream.Read(result, 0, result.Length);
            return result;
        }

        public static void WriteDoubleNull([NotNull] this Stream stream)
        {
            stream.Write(new byte[] { 0x00, 0x00 }, 0, 2);
        }
    }
}
