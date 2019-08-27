using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTicket
{
    class PiterTicket : Ticket
    {
        public static bool CheckIfLucky(int[] number)
        {
            int oddSum = 0;
            int evenSum = 0;

            for (int i = THE_NUMBER_OF_DIGITS - 1; i > 0; i--)
            {
                if (number[i] % 2 == 0) 
                {
                    evenSum += number[i];
                }
                else
                {
                    oddSum += number[i];
                }
            }

            if (oddSum == evenSum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
