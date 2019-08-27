using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LuckyTicket
{
    abstract class Ticket
    {
        public const int THE_NUMBER_OF_DIGITS = 6;

        #region properties

        [Required]
        protected int[] Number { get; set; }  //TODO: check the number

        protected bool IsLucky { get; set; }

        TicketType Type { get; set; }

        #endregion

        public static TicketType GetTicketType(string str)
        {
            if (str.Equals("Piter"))
            {
                return TicketType.Piter;
            }
            if (str.Equals("Moskow"))
            {
                return TicketType.Moskow;
            }
            else
            {
                throw new FormatException(Messages.ERROR_FILE_BEGINING);
            }
        }
    }
}
