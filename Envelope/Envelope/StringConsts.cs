using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envelope
{
    class StringConsts
    {
        #region messages

        public const string FIRST_IN_SECOND = "You can put the first envelope in the second.";
        public const string SECOND_IN_FIRST = "You can put the first envelope in the second.";
        public const string ENTER_LENGTH = "Enter length of the envelope: ";
        public const string ENTER_WIDTH = "Enter width of the envelope: ";
        public const string FIRST_ENVELOPE = "__First envelope__";
        public const string SECOND_ENVELOPE = "__Second envelope__";
        public const string CONTINUE = "Do you want to check another envelopes?  ";

        #endregion

        #region errors

        public const string WRONG_FORMAT_ERROR = "You shold write a float number here.";
        public const string NEGATIVE_NUM_ERROR = "You shold write a positive number.";

        #endregion
    }
}
