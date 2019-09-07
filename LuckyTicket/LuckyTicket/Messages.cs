using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTicket
{
    public class Messages
    {
        #region messages

        public const string ENTER_MIN = "Please enter minimum ticket number:";
        public const string ENTER_MAX = "Please enter maximum ticket number:";
        public const string INSTRUCTION = "Path to the file with algorithm type must be indicated in ";

        #endregion

        #region errors

        public const string ERROR_FORMAT = "Min and Max must contain only digits.";
        public readonly static string ERROR_DIGITS_NUMBER = $"The ticket must have {Ticket.NumberLength} characters.";
        public const string ERROR_WRONG_PATH = "Wrong path.";
        public const string ERROR_NO_ALGORITHM = "The first line of file must be the type of ticket('Piter' or 'Moskow')";

        #endregion       
        
    }
}
