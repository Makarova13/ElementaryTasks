namespace LuckyTicket
{
    public class MoskowTicketAlgorithm: ICheckIfLucky
    {
        public void CheckIfLucky(Ticket number)
        {
            uint leftSum = 0;
            uint rightSum = 0;
            int middle = Ticket.NumberLength / 2;

            for (int i = middle - 1; i >= 0; i--)
            {
                leftSum += number[i];
            }

            for (int i = Ticket.NumberLength - 1; i >= middle; i--)
            {
                rightSum += number[i];
            }

            number.IsLucky = (rightSum == leftSum);
        }

        public override string ToString()
        {
            return Messages.MOSKOW_ALGORITHM;
        }
    }
}
