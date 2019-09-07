using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTicket
{
    public class TicketValidator
    {
        public static int ValidateRange(string str)
        {
            if (!int.TryParse(str, out int number))
            {
                throw new FormatException(Messages.ERROR_FORMAT);
            }

            if(str.Length != Ticket.NumberLength)
            {
                throw new FormatException(Messages.ERROR_DIGITS_NUMBER);
            }

            return number;
        }
    }
}
