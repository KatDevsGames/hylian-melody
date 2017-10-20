using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace HylianMelody.NSPC
{
    public interface ITrack : ISerializable, IEquatable<ITrack>
    {
        int Size { get; }
        ushort Offset { get; }
        void WriteBytes([NotNull] Stream stream);
        List<Command> Commands { get; }
        void LoadBytes([NotNull] Stream stream, long origin, ushort baseAddr, SongBank bank);
        void SetInternalPointers(ref ushort offset);
    }
}
