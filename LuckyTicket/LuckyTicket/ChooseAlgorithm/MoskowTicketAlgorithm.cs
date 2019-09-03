using System;

namespace LuckyTicket
{
    class MoskowTicketAlgorithm: ICheckIfLucky
    {
        public const int THE_NUMBER_OF_DIGITS = 6;

        public void CheckIfLucky(Ticket number)
        {
            if(number.Length != THE_NUMBER_OF_DIGITS)
            {
                throw new FormatException(Messages.ERROR_NUMBER_OF_DIGITS);
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

             number.IsLucky = (rightSum == leftSum);
        }
    }
}
