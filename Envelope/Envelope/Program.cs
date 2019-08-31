using System;
using System.Collections.Generic;
using UserInterface;
using Validator;

namespace Envelope
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleUI UI = new ConsoleUI();

            new Application(UI).Run(args);          
        }
    }
}
