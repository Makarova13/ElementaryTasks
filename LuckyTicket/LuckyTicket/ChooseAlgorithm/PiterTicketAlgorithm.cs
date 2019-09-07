namespace LuckyTicket
{
    class PiterTicketAlgorithm: ICheckIfLucky
    {
        uint oddSum = 0;
        uint evenSum = 0;

        public void CheckIfLucky(Ticket number)
        {


            for (int i = Ticket.NumberLength - 1; i >= 0; i--)
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

            number.IsLucky = (oddSum == evenSum);
        }
    }
}
