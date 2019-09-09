using System.IO;
using UserInterface;
using NLog;

namespace LuckyTicket
{
    class Program
    {
        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            IUserInterface userInterface = new ConsoleUI();

            try
            {
                new Application(userInterface, logger);
            }
            catch (FileNotFoundException ex)
            {
                userInterface.ShowMessage(ex.Message);
                logger.Error(ex, ex.Message);
                userInterface.Pause();
            }
        }
    }
}
