using System;
using UserInterface;
using System.IO;
using OperationsWithNums;

namespace LuckyTicket
{
    public class Application
    {
        public IUserInterface UI { get; }

        public Application(IUserInterface ui, string path)
        {
            UI = ui;
            Run(path);
        }

        private void Run(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException(Messages.ERROR_WRONG_PATH);
            }

            try
            {
                GetMinAndMax(out int min, out int max);

                TicketsAnalyser ticketsAnalyser = new TicketsAnalyser(
                       GetAlgorithm(path), min, max);

                UI.ShowMessage($"Count of lucky tickets: {ticketsAnalyser.AmountOfLucky}");
            }
            catch (FormatException ex)
            {
                UI.ShowMessage(ex.Message);
            }

            UI.Pause();
        }

        private ICheckIfLucky GetAlgorithm(string path)
        {
            Ticket ticket = new Ticket();

            using (StreamReader file = new StreamReader(path))
            {
                Enum.TryParse(file.ReadLine(), out TicketType ticketType);

                switch (ticketType)
                {
                    case TicketType.Moskow:
                        return new MoskowTicketAlgorithm();

                    case TicketType.Piter:
                        return new PiterTicketAlgorithm();

                    default:
                        throw new FormatException(Messages.ERROR_NO_ALGORITHM);
                }
            }
        }

        private void GetMinAndMax(out int min, out int max)
        {
            min = 0;
            max = 0;

            UI.ShowMessage(Messages.ENTER_MIN);
            min = TicketValidator.ValidateRange(UI.ReadLine());

            UI.ShowMessage(Messages.ENTER_MAX);
            max = TicketValidator.ValidateRange(UI.ReadLine());

            if (max < min)
            {
                Operations.Swipe(ref max, ref min);
            }
        }
    }
}
