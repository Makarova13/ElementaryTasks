using System;
using System.IO;

namespace LuckyTicket
{
    public static class AlgorithmChooser
    {
        public static ICheckIfLucky GetAlgorithm(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                if(!Enum.TryParse(file.ReadLine(), out TicketType ticketType))
                {
                    throw new FormatException(Messages.ErrorNoAlgorithm);
                }

                switch (ticketType)
                {
                    case TicketType.Moskow:
                        return new MoskowTicketAlgorithm();

                    case TicketType.Piter:
                        return new PiterTicketAlgorithm();

                    default:
                        throw new FormatException(Messages.ErrorNoAlgorithm);
                }
            }
        }
    }
}
