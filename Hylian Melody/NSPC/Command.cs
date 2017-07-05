using System;
using System.IO;
using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace HylianMelody.NSPC
{
    public class Command : ISerializable, IEquatable<Command>
    {
        public CommandValue Value { get; private set; } = CommandValue.Return;

        [NotNull]
        public byte?[] Parameters { get; } = new byte?[3];

        public static implicit operator byte([NotNull] Command c) => (byte)c.Value;

        [NotNull]
        public static implicit operator Command(byte b) => new Command((CommandValue)b);

        public Command() { }

        public Command(CommandValue value) { Value = value; }

        public Command([NotNull] SerializationInfo info, StreamingContext context)
        {
            Value = (CommandValue)info.GetByte("value");
            byte[] parameters = (byte[])info.GetValue("parameters", typeof(byte[]));
            for (int i = 0; i < 3; i++) { Parameters[i] = parameters[i]; }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("value", (byte) Value);
            info.AddValue("parameters", Parameters);
        }

        public override string ToString()
        {
            string result = Enum.GetName(typeof(CommandValue), Value) ?? string.Empty;
            if (string.IsNullOrWhiteSpace(result)) { result = "[" + ((byte)Value).ToString("X2") + "]"; }
            if (Size > 1)
            {
                for(int i=0;i<(Size-1);i++)
                {
                    result += " " + ((Parameters[i] ?? 0)).ToString("X2");
                }
            }
            return result;
        }

        public void LoadBytes([NotNull] Stream stream, long origin, ushort baseAddr)
        {
            Value = (CommandValue) (stream.ActuallyReadByte() ?? ((byte) CommandValue.Return));
            if ((Value >= (CommandValue) 0x01) && (Value <= (CommandValue) 0x7F))
            {
                byte nextByte = stream.Peek();
                if (nextByte < 0x80)
                {
                    Parameters[0] = nextByte;
                    stream.Seek(1, SeekOrigin.Current);
                    return;
                }
            }
            if (Size <= 1) { return; }
            for (int i = 0; i < (Size - 1); i++)
            {
                Parameters[i] = stream.ActuallyReadByte();
            }
            //byte[] result = new byte[Size - 1];
            //for (int i = 0; i < result.Length; i++) { result[i] = Parameters[i] ?? 0; }
            //stream.Read(result, 0, result.Length);
        }

        public int Size
        {
            get
            {
                if ((Value >= (CommandValue)0x01) && (Value <= (CommandValue)0x7F))
                {
                    return ((Parameters[0] == null) ? 1 : 2);
                }
                switch (Value)
                {
                    case CommandValue.SetInstrument:
                    case CommandValue.Pan:
                    case CommandValue.MasterVolume:
                    case CommandValue.Tempo:
                    case CommandValue.GlobalTranspose:
                    case CommandValue.PerVoiceTranspose:
                    case CommandValue.Volume:
                    case CommandValue.VibratoFade:
                    case CommandValue.Tuning:
                    case CommandValue.PercussionPatchBase:
                        return 2;

                    case CommandValue.PanFade:
                    case CommandValue.MasterVolumeFade:
                    case CommandValue.TempoFade:
                    case CommandValue.VolumeFade:
                        return 3;

                    case CommandValue.VibratoOn:
                    case CommandValue.TremoloOn:
                    case CommandValue.CallSubroutine:
                    case CommandValue.PitchEnvelopeTo:
                    case CommandValue.PitchEnvelopeFrom:
                    case CommandValue.EchoVBits:
                    case CommandValue.EchoParameters:
                    case CommandValue.EchoVolumeFade:
                    case CommandValue.PitchSlide:
                        return 4;

                    default:
                        return 1;

                }
            }
        }

        public enum CommandValue : byte
        {
            Return = 0,
            

            //Notes
            C1 = 0x80,
            Cs1 = 0x81,
            D1 = 0x82,
            Ds1 = 0x83,
            E1 = 0x84,
            F1 = 0x85,
            Fs1 = 0x86,
            G1 = 0x87,
            Gs1 = 0x88,
            A1 = 0x89,
            As1 = 0x8A,
            B1 = 0x8B,

            C2 = 0x8C,
            Cs2 = 0x8D,
            D2 = 0x8E,
            Ds2 = 0x8F,
            E2 = 0x90,
            F2 = 0x91,
            Fs2 = 0x92,
            G2 = 0x93,
            Gs2 = 0x94,
            A2 = 0x95,
            As2 = 0x96,
            B2 = 0x97,

            C3 = 0x98,
            Cs3 = 0x99,
            D3 = 0x9A,
            Ds3 = 0x9B,
            E3 = 0x9C,
            F3 = 0x9D,
            Fs3 = 0x9E,
            G3 = 0x9F,
            Gs3 = 0xA0,
            A3 = 0xA1,
            As3 = 0xA2,
            B3 = 0xA3,

            C4 = 0xA4,
            Cs4 = 0xA5,
            D4 = 0xA6,
            Ds4 = 0xA7,
            E4 = 0xA8,
            F4 = 0xA9,
            Fs4 = 0xAA,
            G4 = 0xAB,
            Gs4 = 0xAC,
            A4 = 0xAD,
            As4 = 0xAE,
            B4 = 0xAF,

            C5 = 0xB0,
            Cs5 = 0xB1,
            D5 = 0xB2,
            Ds5 = 0xB3,
            E5 = 0xB4,
            F5 = 0xB5,
            Fs5 = 0xB6,
            G5 = 0xB7,
            Gs5 = 0xB8,
            A5 = 0xB9,
            As5 = 0xBA,
            B5 = 0xBB,

            C6 = 0xBC,
            Cs6 = 0xBD,
            D6 = 0xBE,
            Ds6 = 0xBF,
            E6 = 0xC0,
            F6 = 0xC1,
            Fs6 = 0xC2,
            G6 = 0xC3,
            Gs6 = 0xC4,
            A6 = 0xC5,
            As6 = 0xC6,
            B6 = 0xC7,

            Tie = 0xC8,
            Rest = 0xC9,
            Percussion0 = 0xCA,
            Percussion1 = 0xCB,
            Percussion2 = 0xCC,
            Percussion3 = 0xCD,
            Percussion4 = 0xCE,
            Percussion5 = 0xCF,
            Percussion6 = 0xD0,
            Percussion7 = 0xD1,
            Percussion8 = 0xD2,
            Percussion9 = 0xD3,
            Percussion10 = 0xD4,
            Percussion11 = 0xD5,
            Percussion12 = 0xD6,
            Percussion13 = 0xD7,
            Percussion14 = 0xD8,
            Percussion15 = 0xD9,
            Percussion16 = 0xDA,
            Percussion17 = 0xDB,
            Percussion18 = 0xDC,
            Percussion19 = 0xDD,
            Percussion20 = 0xDE,
            Percussion21 = 0xDF,

            SetInstrument = 0xE0,
            Pan = 0xE1,
            PanFade = 0xE2,
            VibratoOn = 0xE3,
            VibratoOff = 0xE4,

            MasterVolume = 0xE5,
            MasterVolumeFade = 0xE6,
            Tempo = 0xE7,
            TempoFade = 0xE8,
            GlobalTranspose = 0xE9,
            PerVoiceTranspose = 0xEA,
            TremoloOn = 0xEB,
            TremoloOff = 0xEC,
            Volume = 0xED,
            VolumeFade = 0xEE,
            CallSubroutine = 0xEF,
            VibratoFade = 0xF0,
            PitchEnvelopeTo = 0xF1,
            PitchEnvelopeFrom = 0xF2,
            PitchEnvelopeOff = 0xF3,
            Tuning = 0xF4,
            EchoVBits = 0xF5,
            EchoOff = 0xF6,
            EchoParameters = 0xF7,
            EchoVolumeFade = 0xF8,
            PitchSlide = 0xF9,
            PercussionPatchBase = 0xFA
        }

        public bool Equals(Command other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            if (Value != other.Value) { return false;}
            for (int i = 0; i < (Size - 1); i++)
            {
                if (Parameters[i] != other.Parameters[i]) { return false; }
            }
            return true;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Command) obj);
        }

        public override int GetHashCode()
        {
            int result = Value.GetHashCode();
            for (int i = 0; i < (Size - 1); i++)
            {
                unchecked
                {
                    result += Parameters[i].GetHashCode();
                }
            }
            return result;
        }
    }
}
