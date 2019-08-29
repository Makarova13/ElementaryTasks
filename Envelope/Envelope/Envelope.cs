using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using TasksHelper;

namespace Envelope
{
    class Envelope
    {
        public Envelope(double length, double width)
        {
            if (width > length)
            {
                OperationsHelper.Swipe(ref width, ref length);
            }

            Length = length;
            Width = width;
        }

        #region properties

        public double Length { get; }

        public double Width { get; }

        #endregion

        public delegate void CanPutInEnvelopeEventHandler(string message);
        public event CanPutInEnvelopeEventHandler CanPutInEnvelope;

        public void CanPutIn(Envelope en)
        {
            if (!this.Equals(en))
            {
                if (this < en)
                {
                    CanPutInEnvelope?.Invoke(StringConsts.FIRST_IN_SECOND);
                }

                else 
                if (this > en)
                {
                    CanPutInEnvelope?.Invoke(StringConsts.SECOND_IN_FIRST);
                }

                else
                {
                    CanPutInEnvelope?.Invoke(StringConsts.NONE_ENVELOPE);
                }
            }
            else
            {
                CanPutInEnvelope?.Invoke(StringConsts.EQUAL_ENVELOPE);
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

        public bool Equals(Envelope en1)
        {
            return Length == en1.Length && Width == en1.Width;
        }
    }
}
