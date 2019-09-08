using System.IO;
using UserInterface;
using NLog;

namespace LuckyTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserInterface userInterface = new ConsoleUI();

            if (args.Length != 1)
            {
                userInterface.ShowMessage(Messages.INSTRUCTION);
                
                userInterface.Pause();
            }

            else
            {
                try
                {
                    new Application(userInterface);
                }
                catch (FileNotFoundException ex)
                {
                    userInterface.ShowMessage(ex.Message);
                    userInterface.Pause();
                }
            }
        }
    }
}
