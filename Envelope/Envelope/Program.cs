using System;
using System.Collections.Generic;
using UserInterface;
using Validator;

namespace Task2Envelope
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleUI UI = new ConsoleUI();
            IArgsValidator argsValidator = new ArgsValidator();
            INumsValidator numsValidator = new NumsValidator();

            new Application(UI, argsValidator, numsValidator).Run(args);          
        }
    }
}
