using System;
using UserInterface;
using System.IO;
using OperationsWithNums;
using NLog;

namespace LuckyTicket
{
    public class Application
    {
        public IUserInterface UI { get; }
        private ILogger Logger { get; set; }

        public Application(IUserInterface ui, ILogger logger)
        {
            Logger = logger;
            UI = ui;
            Run();
        }

        private void Run()
        {
            Logger.Info(Messages.STARTED);
            string path = UI.ReadLine();

            if (!File.Exists(path))
            {
                throw new FileNotFoundException(Messages.ERROR_WRONG_PATH);
            }

            try
            {
                GetMinAndMax(out int min, out int max);

                TicketsAnalyser ticketsAnalyser = new TicketsAnalyser(
                       GetAlgorithm(path), Logger, min, max);

                UI.ShowMessage($"Count of lucky tickets: {ticketsAnalyser.AmountOfLucky}");
            }
            catch (FormatException ex)
            {
                Logger.Error(ex, ex.Message);
                UI.ShowMessage(ex.Message);
            }

            UI.Pause();
        }

        private ICheckIfLucky GetAlgorithm(string path)
        {
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
            TicketValidator ticketValidator = new TicketValidator();

            UI.ShowMessage(Messages.ENTER_MIN);
            min = ticketValidator.ValidateRange(UI.ReadLine());

            UI.ShowMessage(Messages.ENTER_MAX);
            max = ticketValidator.ValidateRange(UI.ReadLine());

            if (max < min)
            {
                Operations.Swipe(ref max, ref min);
            }
        }
    }
}
