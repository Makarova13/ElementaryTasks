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

        #endregion

        #region errors

        public const string ERROR_NUMBER_OF_DIGITS = "Moskow ticket number must have 6 digits.";
        public const string ERROR_NUMBER_FORMAT = "Ticket's number must contain only digits.";
        public const string ERROR_WRONG_PATH = "Wrong path.";
        public const string ERROR_NO_ALGORITHM = "The first line of file must be the type of ticket('Piter' or 'Moskow')";

        #endregion       
        
    }
}
