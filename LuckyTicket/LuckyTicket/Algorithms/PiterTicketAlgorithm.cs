namespace LuckyTicket
{
    public class PiterTicketAlgorithm: ICheckIfLucky
    {
        public void CheckIfLucky(Ticket number)
        {
            uint oddSum = 0;
            uint evenSum = 0;

            for (int i = Ticket.NumberLength - 1, j = 1; i >= 0; i--, j++)
            {
                if (j % 2 == 0)
                {
                    evenSum += number[i];
                }
                else
                {
                    oddSum += number[i];
                }
            }

            number.IsLucky = (oddSum == evenSum);
        }

        public override string ToString()
        {
            return Messages.PITER_ALGORITHM;
        }
    }
}
