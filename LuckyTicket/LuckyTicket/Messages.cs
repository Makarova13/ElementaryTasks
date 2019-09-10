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

        public const string ENTER_PATH = "Please enter path to the file with algorithm:";
        public const string ENTER_MIN = "Please enter minimum ticket number:";
        public const string ENTER_MAX = "Please enter maximum ticket number:";

        #endregion

        #region errors

        public const string ERROR_FORMAT = "Min and Max must contain only digits.";
        public readonly static string ERROR_DIGITS_NUMBER = $"The ticket must have {Ticket.NumberLength} characters.";
        public const string ERROR_WRONG_PATH = "Wrong path.";
        public const string ERROR_NO_ALGORITHM = "The first line of file must be the type of ticket('Piter' or 'Moskow')";

        #endregion

        #region Logger messages

        public const string STARTED = "Application started";
        public const string TICKETS_ANALYSER = "Tickets analyser created. Algorythm: ";
        public const string MOSKOW_ALGORITHM = "Moskow ticket algorithm has been chosen.";
        public const string PITER_ALGORITHM = "Piter ticket algorithm has been chosen.";

        #endregion

    }
}
