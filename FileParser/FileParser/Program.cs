using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            }
            catch (FormatException ex)
            {
                UI.ShowMessage(ex.Message);
            }
        }
    }
}
