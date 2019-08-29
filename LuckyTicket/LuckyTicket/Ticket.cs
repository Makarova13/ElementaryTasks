using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LuckyTicket
{
    abstract class TicketAnalyser
    {
        public const int THE_NUMBER_OF_DIGITS = 6;

        #region properties

        protected int[] Number { get; set; }  //TODO: check the number

        #endregion

        public static bool TryGetAlgorithm(string str, out ProcessTicket process)
        {
            str = str.ToUpper();
            if (str.Equals("PITER"))
            {
                process = PiterTicket.CheckIfLucky;
                return true;
            }
            if (str.Equals("MOSKOW"))
            {
                process = MoskowTicket.CheckIfLucky;
                return true;
            }
            else
            {
                process = null;
                return false;
            }
        }

    }
}
