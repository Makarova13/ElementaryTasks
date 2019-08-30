using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTicket
{
    class TicketValidator
    {
        public bool ValideType(TicketType ticketType)
        {
            switch (ticketType)
            {
                case TicketType.Moskow:
                    return true;

                case TicketType.Piter:
                    return true;

                default: return false;
            }
        }
    }
}
