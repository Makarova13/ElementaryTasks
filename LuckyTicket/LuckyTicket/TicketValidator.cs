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
    }
}
