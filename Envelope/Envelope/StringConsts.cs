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
        public const string NONE_ENVELOPE = "None envelope can be put in in another.";
        public const string EQUAL_ENVELOPE = "Envelopes are equal.";
        public const string INSTRUCTION = "To check envelopes you can start the app with their lengths and widths as arguments.";

        #endregion

        #region errors

        public const string WRONG_FORMAT_ERROR = "You should write a float number here.";
        public const string NEGATIVE_NUM_ERROR = "You should write a positive number.";

        #endregion
    }
}
