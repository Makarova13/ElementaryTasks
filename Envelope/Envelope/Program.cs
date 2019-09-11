using NLog;
using UserInterface;
using Validator;

namespace Task2Envelope
{
    class Program
    {
        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            IUserInterface UI = new ConsoleUI();
            IArgsValidator argsValidator = new ArgsValidator();
            INumsValidator numsValidator = new NumsValidator();

            new Application(UI, logger, argsValidator, numsValidator).Run(args);          
        }
    }
}
