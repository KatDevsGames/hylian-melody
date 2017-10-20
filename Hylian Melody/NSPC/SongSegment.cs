using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace HylianMelody.NSPC
{
    public class SongSegment : ISerializable, IEquatable<SongSegment>
    {
        public const int TRACKS_PER_SEGMENT = 8;

        public ushort Offset { get; set; }

        public int Size => Tracks.Where(t => (t is Track)).Sum(t => t.Size) + (TRACKS_PER_SEGMENT * 2);

        [NotNull, ItemCanBeNull]
        public ITrack[] Tracks { get; } = new ITrack[TRACKS_PER_SEGMENT];

        public SongSegment()
        {
            for (int i = 0; i < TRACKS_PER_SEGMENT; i++)
            {
                Tracks[i] = new Track();
            }
        }

        public SongSegment([NotNull] SerializationInfo info, StreamingContext context)
        {
            Offset = info.GetUInt16("offset");
            ITrack[] tracks = (ITrack[]) info.GetValue("tracks", typeof(Track[]));//fix
            for (int i = 0; i < TRACKS_PER_SEGMENT; i++)
            {
                Tracks[i] = tracks[i];
            }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("offset", Offset);
            info.AddValue("tracks", Tracks);
        }

        public void SetInternalPointers(ref ushort offset)
        {
            Offset = offset;
            offset += (TRACKS_PER_SEGMENT * 2);
            foreach (ITrack t in Tracks)
            {
                t.SetInternalPointers(ref offset);
            }
        }

        public void WriteBytes([NotNull] Stream stream, ushort baseAddr)
        {
            for (int i = 0; i < TRACKS_PER_SEGMENT; i++)
            {
                if (Tracks[i] == null)
                {
                    stream.WriteDoubleNull();
                    continue;
                }
                stream.WriteSNESWord((ushort) (Tracks[i].Offset + baseAddr));
            }
            for (int i = 0; i < TRACKS_PER_SEGMENT; i++)
            {
                Tracks[i].WriteBytes(stream);
            }
        }

        public void LoadBytes([NotNull] Stream stream, long origin, ushort baseAddr, SongBank bank)
        {
            long localOrigin = stream.Position;
            for (int i = 0; i < TRACKS_PER_SEGMENT; i++)
            {
                stream.Position = localOrigin + (2 * i);
                ushort nextAddr = stream.ReadSNESWord();
                stream.Position = origin + 4 + (nextAddr - baseAddr);
                Tracks[i] = new Track();
                Tracks[i].LoadBytes(stream, origin, baseAddr, bank);
            }
        }

        public void ProcessOverlap([NotNull] SongSegment other)
        {
            foreach (ITrack t1 in Tracks)
            {
                if(!(t1 is Track)) { continue; }
                foreach (ITrack t2 in other.Tracks)
                {
                    if (!(t2 is Track)) { continue; }
                    var subset = ((Track)t1).DetectSubset((Track)t2);
                    if (subset == null) { continue; }
                    TrackPointer p = new TrackPointer(subset.Value.greater, subset.Value.offset);
                    if (subset.Value.greater.Equals(t1)) { other.ReplaceSegment(p, (Track)t2); }
                    ReplaceSegment(p, (Track)t1);
                }
            }
        }

        public void ReplaceSegment([NotNull] TrackPointer pointer, [NotNull] Track destination)
        {
            for (int i = 0; i < TRACKS_PER_SEGMENT; i++)
            {
                if (!destination.Equals(Tracks[i])) { continue; }
                Tracks[i] = pointer;
            }
        }

        public bool Equals(SongSegment other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            if (Size != other.Size) { return false; }
            for (int i = 0; i < 8; i++)
            {
                if ((Tracks[i] == null) && (other.Tracks[i] == null)) { continue; }
                if ((Tracks[i] == null) && (other.Tracks[i] != null)) { return false; }
                if ((Tracks[i] != null) && (other.Tracks[i] == null)) { return false; }
                if (!Tracks[i].Equals(other.Tracks[i])) { return false; }
            }
            return true;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((SongSegment) obj);
        }

        public override int GetHashCode()
        {
            int result = Size.GetHashCode();
            foreach (Track t in Tracks)
            {
                unchecked
                {
                    result += t.GetHashCode();
                }
            }
            return result;
        }
    }
}
