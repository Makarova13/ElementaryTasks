using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTicket
{
    class MoskowTicket : Ticket
    {
        public static bool CheckIfLucky(int[] number)
        {
            int leftSum = 0;
            int rightSum = 0;
            int middle = THE_NUMBER_OF_DIGITS / 2;

            for (int i = middle - 1; i > 0; i--)
            {
                leftSum += number[i];
            }

            for (int i = THE_NUMBER_OF_DIGITS - 1; i >= middle; i--)
            {
                rightSum += number[i];
            }

            if (rightSum == leftSum)
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
