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
                Operations.Swap(ref width, ref length);
            }

            Length = length;
            Width = width;
        }

        public Outcomes CheckPutIn(Envelope en)
        {
            if (Equals(en))
            {
                return Outcomes.Equal;
            }

            if (this < en)
            {
                return Outcomes.FirstInSecond;
            }

            if (this > en)
            {
                return Outcomes.SecondInFirst;
            }

            EnvelopeChecked?.Invoke(StringConsts.NONE_ENVELOPE);

            return Outcomes.None;
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
