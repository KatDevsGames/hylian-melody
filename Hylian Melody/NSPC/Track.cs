using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace HylianMelody.NSPC
{
    public class Track : ITrack, IEquatable<Track>
    {
        public ushort Offset { get; set; }

        [NotNull, ItemNotNull]
        public List<Command> Commands { get; } = new List<Command>();

        public int Size => Commands.Sum(c => c.Size);

        public ushort EndOffset => (ushort)(Offset + Size);

        public Track() { }

        public Track([NotNull] SerializationInfo info, StreamingContext context)
        {
            Offset = info.GetUInt16("offset");
            Commands.AddRange((List<Command>) info.GetValue("commands", typeof(List<Command>)));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("offset", Offset);
            info.AddValue("commands", Commands);
        }

        private int GetInternalOffset(Track lesser)
        {
            int size = Size - lesser.Size;
            if (size == 0) { return 0; }
            return Commands.TakeWhile(c =>
            {
                size -= c.Size;
                if (size < 0) { throw new InvalidOperationException(); }
                return size > 0;
            }).Sum(c => c.Size);
        }

        public byte[] GetBytes() => Commands.Select(c => (byte)c.Value).ToArray();

        public void SetInternalPointers(ref ushort offset)
        {
            Offset = offset;
            offset += (ushort)Size;
        }

        public void WriteBytes(Stream stream)
        {
            foreach (Command c in Commands)
            {
                stream.WriteByte((byte) c.Value);
                if (c.Size > 1)
                {
                    byte[] result = new byte[c.Size - 1];
                    for (int i = 0; i < result.Length; i++) { result[i] = c.Parameters[i] ?? 0; }
                    stream.Write(result, 0, result.Length);
                }
            }
        }
        
        public (Track greater, int offset)? DetectSubset([NotNull] Track other)
        {
            if (EndOffset != other.EndOffset) { return null; }
            return ((Size >= other.Size) ? (this, GetInternalOffset(other)) : (other, other.GetInternalOffset(this)));
        }

        public void LoadBytes(Stream stream, long origin, ushort baseAddr)
        {
            //long localOrigin = stream.Position;
            Command c;
            do
            {
                c = new Command();
                c.LoadBytes(stream, origin, baseAddr);
                Commands.Add(c);
            } while (c.Value != Command.CommandValue.Return);
        }

        public bool Equals(ITrack other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Offset == other.Offset && Commands.Equals(other.Commands);
        }

        public bool Equals(Track other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Offset == other.Offset && Commands.Equals(other.Commands);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Track) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Offset.GetHashCode() * 397) ^ Commands.GetHashCode();
            }
        }
    }
}
