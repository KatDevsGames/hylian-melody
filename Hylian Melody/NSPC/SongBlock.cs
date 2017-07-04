using System;
using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace HylianMelody.NSPC
{
    public class SongBlock : ISerializable, IEquatable<SongBlock>
    {
        private Guid _guid = Guid.NewGuid();

        public SongBlock() { }

        public SongBlock([NotNull] SerializationInfo info, StreamingContext context)
        {
            _guid = Guid.Parse(info.GetString("guid"));
            Type = (StatusType)info.GetByte("type");
            Loop = info.GetByte("type");
            SegmentReference = (SongSegment)info.GetValue("reference", typeof(SongSegment));
            Offset = info.GetUInt16("offset");
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("guid", _guid.ToString());
            info.AddValue("type", (byte)Type);
            info.AddValue("loop", Loop);
            info.AddValue("segmentReference", SegmentReference);
            info.AddValue("blockReference", BlockReference);
            info.AddValue("offset", Offset);
        }

        public enum StatusType : byte
        {
            Play,
            Repeat,
            GoTo,
            Stop
        }

        public StatusType Type { get; set; }
        public ushort Loop { get; set; }
        public SongSegment SegmentReference { get; set; }
        public SongBlock BlockReference { get; set; }
        public ushort Offset { get; set; }

        public static SongBlock StopBlock => new SongBlock {Type = StatusType.Stop};

        public bool Equals(SongBlock other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _guid.Equals(other._guid);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((SongBlock)obj);
        }

        public override int GetHashCode() => _guid.GetHashCode();
    }
}