using System;
using System.IO;
using UserInterface;

namespace FileParser
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleUI UI = new ConsoleUI();

            try
            {
                ForArgs.WorkWithArgs(args);
            }
            catch (FileNotFoundException ex)
            {
                UI.ShowMessage(ex.Message);
                UI.Pause();
            }
            catch (FormatException ex)
            {
                UI.ShowMessage(ex.Message);
                UI.Pause();
            }
        }
    }
}
