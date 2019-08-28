using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksHelper;

namespace LuckyTicket
{
    class TicketValidator
    {
        public static bool CheckArgs(string[] args)
        {
            if(args.Length != 1)
            {

                return false;
            }
            return true;
        }
    }
}
