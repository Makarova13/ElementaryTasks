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

        public void CheckPutIn(Envelope en)
        {
            if (Equals(en))
            {
                EnvelopeChecked?.Invoke(StringConsts.EQUAL_ENVELOPES);               
            }

            else
            {
                if (this < en)
                {
                    EnvelopeChecked?.Invoke(StringConsts.FIRST_IN_SECOND);
                }

                else if (this > en)
                {
                    EnvelopeChecked?.Invoke(StringConsts.SECOND_IN_FIRST);
                }

                else
                {
                    EnvelopeChecked?.Invoke(StringConsts.NONE_ENVELOPE);
                }
            }          
        }

        public static bool operator <(Envelope en1, Envelope en2)
        {
            return (en1.Length < en2.Length && en1.Width < en2.Width);
        }

        public static bool operator >(Envelope en1, Envelope en2)
        {
            return en2.Length < en1.Length && en2.Width < en1.Width;
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
