using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTicket
{
    class MoskowTicketAlgorithm: ICheckIfLucky
    {
        public const int THE_NUMBER_OF_DIGITS = 6;

        public bool CheckIfLucky(byte[] number)
        {
            if(number.Length != THE_NUMBER_OF_DIGITS)
            {
                throw new FormatException();
            }
            uint leftSum = 0;
            uint rightSum = 0;
            int middle = THE_NUMBER_OF_DIGITS / 2;

            for (int i = middle - 1; i >= 0; i--)
            {
                leftSum += number[i];
            }

            for (int i = THE_NUMBER_OF_DIGITS - 1; i >= middle; i--)
            {
                rightSum += number[i];
            }

            return (rightSum == leftSum);
        }
    }
}
