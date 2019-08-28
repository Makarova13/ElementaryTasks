using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTicket
{
    class Messages
    {
        #region messages

        public const string ENTER_PATH = "Please enter the path to your file:  ";
        public const string HELP = "You should enter the type of ticket as argument.";

        #endregion

        #region errors

        public static string ERROR_NUMBER_OF_DIGITS = string.Format("Ticket number must have {0} digits.", Ticket.THE_NUMBER_OF_DIGITS);
        public const string ERROR_NUMBER_FORMAT = "Ticket's number must contain only digits.";
        public const string ERROR_WRONG_PATH = "Wrong path.";

        #endregion       
        
    }
}
