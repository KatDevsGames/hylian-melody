using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace HylianMelody.NSPC
{
    public class TrackPointer : ITrack, IEquatable<TrackPointer>
    {
        [NotNull]
        private readonly Track _track;

        private readonly int _offset;

        public int Size => Commands.Sum(c => c.Size);

        public ushort Offset => (ushort)(_track.Offset + _track.Commands.Take(_offset).Sum(c => c.Size));

        [NotNull, ItemNotNull]
        public List<Command> Commands => _track.Commands.Skip(_offset).ToList();

        public TrackPointer([NotNull] Track track, int offset)
        {
            _track = track;
            _offset = offset;
        }

        public TrackPointer([NotNull] SerializationInfo info, StreamingContext context)
            => throw new NotImplementedException();

        public void GetObjectData(SerializationInfo info, StreamingContext context)
            => throw new NotImplementedException();

        public bool Equals(ITrack other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Offset == other.Offset && Commands.Equals(other.Commands);
        }

        public bool Equals(TrackPointer other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return (_track.Equals(other._track) && (_offset == other._offset));
        }

        public void SetInternalPointers(ref ushort offset) { }

        public void WriteBytes(Stream stream) { }

        public void LoadBytes(Stream stream, long origin, ushort baseAddr)
            => throw new InvalidOperationException();
    }
}
