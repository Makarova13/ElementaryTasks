using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTicket
{
    class PiterTicketAlgorithm: ICheckIfLucky
    {
        public bool CheckIfLucky(byte[] number)
        {
            uint oddSum = 0;
            uint evenSum = 0;

            for (int i = number.Length - 1; i >= 0; i--)
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
