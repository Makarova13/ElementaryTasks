namespace LuckyTicket
{
    class TicketAnalyser
    {
        public TicketAnalyser(ICheckIfLucky checkIfLucky)
        {
            Algorithm = checkIfLucky;
        }

        public ICheckIfLucky Algorithm { private get; set; }

        public bool CheckIfLucky(byte[] numbers)
        {
            return Algorithm.CheckIfLucky(numbers);
        }
    }
}
