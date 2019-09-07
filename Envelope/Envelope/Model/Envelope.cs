using System;
using OperationsWithNums;

namespace Task2Envelope
{
    public class Envelope
    {
        #region properties

        public float Length { get; }

        public float Width { get; }

        #endregion

        public event Action<string> EnvelopeChecked;

        public Envelope(float length, float width)
        {
            if (width > length)
            {
                Operations.Swipe(ref width, ref length);
            }

            Length = length;
            Width = width;
        }

        public bool CheckPutIn(Envelope en)
        {
            if (Equals(en))
            {
                EnvelopeChecked?.Invoke(StringConsts.EQUAL_ENVELOPES);
                return false;
            }

            if (this < en)
            {
                EnvelopeChecked?.Invoke(StringConsts.FIRST_IN_SECOND);
                return true;
            }

            if (this > en)
            {
                EnvelopeChecked?.Invoke(StringConsts.SECOND_IN_FIRST);
                return true;
            }

            EnvelopeChecked?.Invoke(StringConsts.NONE_ENVELOPE);

            return false;
        }

        public static bool operator <(Envelope en1, Envelope en2)
        {
            return (en1.Length < en2.Length) && (en1.Width < en2.Width);
        }

        public static bool operator >(Envelope en1, Envelope en2)
        {
            return (en1.Length > en2.Length) && (en1.Width > en2.Width);
        }

        public override bool Equals(object en1)
        {
            if (en1 is Envelope) 
            {
                return Length == ((Envelope)en1).Length && Width == ((Envelope)en1).Width;
            }
            else
            {
                throw new InvalidCastException();
            }
        }
    }
}
