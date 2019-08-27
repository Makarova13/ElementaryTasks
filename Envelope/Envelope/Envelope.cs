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
        public static event CanPutInEnvelopeEventHandler CanPutInEnvelope;

        public bool CanPutIn(Envelope en)
        {
            if (this < en) 
            {              
                CanPutInEnvelope(StringConsts.FIRST_IN_SECOND);
                return true;
            }

            if (this > en)
            {
                CanPutInEnvelope(StringConsts.SECOND_IN_FIRST);
                return true;
            }

            return false;
        }

        public static bool operator <(Envelope en1, Envelope en2)
        {
            return (en1.Length < en2.Length && en1.Width < en2.Width);
        }

        public static bool operator >(Envelope en1, Envelope en2)
        {
            return en2.Length < en1.Length && en2.Width < en1.Width;
        }
    }
}
