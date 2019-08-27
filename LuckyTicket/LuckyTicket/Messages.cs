using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTicket
{
    class Messages
    {
        public static string ERROR_NUMBER_OF_DIGITS = string.Format("Ticket number must be {0} digits.", Ticket.THE_NUMBER_OF_DIGITS);
        public const string ERROR_FORMAT = "Ticket's number must contain only digits.";
        public const string ENTER_PATH = "Please enter the path to your file:  ";
        public const string ERROR_FILE_BEGINING = "File must begin with type of tickets('Piter' or 'Moskow')";
    }
}
