namespace LuckyTicket
{
    class PiterTicketAlgorithm: ICheckIfLucky
    {
        public void CheckIfLucky(Ticket number)
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

            number.IsLucky = (oddSum == evenSum);
        }
    }
}
