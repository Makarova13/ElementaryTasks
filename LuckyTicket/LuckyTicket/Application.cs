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

            UI.ShowMessage(Messages.ENTER_PATH);
            string path = UI.ReadLine();

            if (!File.Exists(path))
            {
                throw new FileNotFoundException(Messages.ERROR_WRONG_PATH);
            }

            try
            {
                var algorithm = AlgorithmChooser.GetAlgorithm(path);
                GetMinAndMax(out int min, out int max);

                TicketsAnalyser ticketsAnalyser = new TicketsAnalyser(
                       algorithm, Logger);

                ticketsAnalyser.CheckAll(min, max);

                UI.ShowMessage($"Count of lucky tickets: {ticketsAnalyser.AmountOfLucky}");
            }
            catch (FormatException ex)
            {
                Logger.Error(ex, ex.Message);
                UI.ShowMessage(ex.Message);
            }

            UI.Pause();
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
                Operations.Swap(ref max, ref min);
            }
        }
    }
}
