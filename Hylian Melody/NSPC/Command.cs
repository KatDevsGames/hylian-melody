using System;
using System.IO;
using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace HylianMelody.NSPC
{
    public class Command : ISerializable, IEquatable<Command>
    {
        public CommandValue Value { get; private set; } = CommandValue.Return;

        private byte?[] _parameters = new byte?[3];

        [NotNull]
        public byte?[] Parameters {
            get
            {
                if ((Value == CommandValue.CallSubroutine) && (Subroutine != null))
                {
                    byte[] temp = Subroutine.Offset.ToSNES();
                    return new byte?[] { temp[0], temp[1], SubRepeat };
                }
                return _parameters;
            }
        }

        [CanBeNull]
        public ITrack Subroutine { get; set; } = null;

        public byte SubRepeat { get; set; } = 0;

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
                result += Environment.NewLine;
                for(int i=0;i<(Size-1);i++)
                {
                    result += ((Parameters[i] ?? 0)).ToString("X2") + " ";
                }
            }
            return result.Trim();
        }

        public void LoadBytes([NotNull] Stream stream, long origin, ushort baseAddr, SongBank bank)
        {
            Value = (CommandValue) (stream.ActuallyReadByte() ?? ((byte) CommandValue.Return));
            if ((Value >= (CommandValue) 0x01) && (Value <= (CommandValue) 0x7F))
            {
                byte nextByte = stream.Peek();
                if (nextByte < 0x80)
                {
                    _parameters[0] = nextByte;
                    stream.Seek(1, SeekOrigin.Current);
                    return;
                }
            }
            if (Size <= 1) { return; }
            
            for (int i = 0; i < (Size - 1); i++)
            {
                _parameters[i] = stream.ActuallyReadByte();
            }
            //byte[] result = new byte[Size - 1];
            //for (int i = 0; i < result.Length; i++) { result[i] = Parameters[i] ?? 0; }
            //stream.Read(result, 0, result.Length);
            if (Value == CommandValue.CallSubroutine)
            {
                long position = stream.Position;
                Subroutine = new Track();
                byte[] offset = { (byte)_parameters[0], (byte)_parameters[1] };
                bank.SeekStream(stream, offset.FromSNES());
                Subroutine.LoadBytes(stream, origin, baseAddr, bank);
                SubRepeat = (byte)_parameters[2];
                stream.Position = position;
            }
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

            //Parameters
            P01 = 0x01,
            P02 = 0x02,
            P03 = 0x03,
            P04 = 0x04,
            P05 = 0x05,
            P06 = 0x06,
            P07 = 0x07,
            P08 = 0x08,
            P09 = 0x09,
            P0A = 0x0A,
            P0B = 0x0B,
            P0C = 0x0C,
            P0D = 0x0D,
            P0E = 0x0E,
            P0F = 0x0F,
            P10 = 0x10,
            P11 = 0x11,
            P12 = 0x12,
            P13 = 0x13,
            P14 = 0x14,
            P15 = 0x15,
            P16 = 0x16,
            P17 = 0x17,
            P18 = 0x18,
            P19 = 0x19,
            P1A = 0x1A,
            P1B = 0x1B,
            P1C = 0x1C,
            P1D = 0x1D,
            P1E = 0x1E,
            P1F = 0x1F,
            P20 = 0x20,
            P21 = 0x21,
            P22 = 0x22,
            P23 = 0x23,
            P24 = 0x24,
            P25 = 0x25,
            P26 = 0x26,
            P27 = 0x27,
            P28 = 0x28,
            P29 = 0x29,
            P2A = 0x2A,
            P2B = 0x2B,
            P2C = 0x2C,
            P2D = 0x2D,
            P2E = 0x2E,
            P2F = 0x2F,
            P30 = 0x30,
            P31 = 0x31,
            P32 = 0x32,
            P33 = 0x33,
            P34 = 0x34,
            P35 = 0x35,
            P36 = 0x36,
            P37 = 0x37,
            P38 = 0x38,
            P39 = 0x39,
            P3A = 0x3A,
            P3B = 0x3B,
            P3C = 0x3C,
            P3D = 0x3D,
            P3E = 0x3E,
            P3F = 0x3F,
            P40 = 0x40,
            P41 = 0x41,
            P42 = 0x42,
            P43 = 0x43,
            P44 = 0x44,
            P45 = 0x45,
            P46 = 0x46,
            P47 = 0x47,
            P48 = 0x48,
            P49 = 0x49,
            P4A = 0x4A,
            P4B = 0x4B,
            P4C = 0x4C,
            P4D = 0x4D,
            P4E = 0x4E,
            P4F = 0x4F,
            P50 = 0x50,
            P51 = 0x51,
            P52 = 0x52,
            P53 = 0x53,
            P54 = 0x54,
            P55 = 0x55,
            P56 = 0x56,
            P57 = 0x57,
            P58 = 0x58,
            P59 = 0x59,
            P5A = 0x5A,
            P5B = 0x5B,
            P5C = 0x5C,
            P5D = 0x5D,
            P5E = 0x5E,
            P5F = 0x5F,
            P60 = 0x60,
            P61 = 0x61,
            P62 = 0x62,
            P63 = 0x63,
            P64 = 0x64,
            P65 = 0x65,
            P66 = 0x66,
            P67 = 0x67,
            P68 = 0x68,
            P69 = 0x69,
            P6A = 0x6A,
            P6B = 0x6B,
            P6C = 0x6C,
            P6D = 0x6D,
            P6E = 0x6E,
            P6F = 0x6F,
            P70 = 0x70,
            P71 = 0x71,
            P72 = 0x72,
            P73 = 0x73,
            P74 = 0x74,
            P75 = 0x75,
            P76 = 0x76,
            P77 = 0x77,
            P78 = 0x78,
            P79 = 0x79,
            P7A = 0x7A,
            P7B = 0x7B,
            P7C = 0x7C,
            P7D = 0x7D,
            P7E = 0x7E,
            P7F = 0x7F,

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
