using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTicket
{
    class TicketValidator
    {
        public bool ValideType(TicketType ticketType, out ICheckIfLucky lucky)
        {
            switch (ticketType)
            {
                case TicketType.Moskow:
                    lucky = new MoskowTicketAlgorithm();
                    return true;

                case TicketType.Piter:
                    lucky = new PiterTicketAlgorithm();
                    return true;

                default:
                    lucky = null;
                    return false;
            }
        }

        public bool ValidateNumber(string str, Ticket ticket)
        {
            char[] charArr = str.ToCharArray();
            int length = charArr.Length;
            byte[] byteArr = new byte[length];

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
