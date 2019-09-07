using UserInterface;

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
                new Application(userInterface, args[0]);
            }
        }
    }
}
