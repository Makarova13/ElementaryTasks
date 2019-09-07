using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTicket
{
    class TicketValidator
    {
        public bool ValidateNumber(string str, Ticket ticket)
        {
            char[] charArr = str.ToCharArray();
            byte[] byteArr = new byte[Ticket.NumberLength];

            for (int i = 0; i < charArr.Length; i++)
            {
                if (!byte.TryParse(charArr[i].ToString(), out byteArr[i]))
                {
                    return false;
                }
            }
            ticket.Number = byteArr;
            return true;
        }
    }
}
