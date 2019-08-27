using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksHelper;

namespace Fibonacci
{
    class Program
    {
        #region string constants

        const string CONTINUE = "If you want to continue, write 'y' or 'yes'     ";
        const string ENTER = "Enter min and max separated by enter";
        const string ERROR = "Wrong format. ";

        #endregion

        static void Main(string[] args)
        {
            int min;
            int max;

            do
            {
                ConsoleUI.Clear();
                ConsoleUI.ShowMessage(ENTER);
      
                if (ConsoleUI.GetMinAndMax(out min, out max))
                {
                    Calculate.GetFibonacciNum(min, max);
                }
                else
                {
                    ConsoleUI.ShowMessage(ERROR);
                }

                ConsoleUI.ShowIntList(Calculate.fibonacciNum);
                ConsoleUI.AskContinue(CONTINUE);

            } while (ConsoleUI.WannaContinue);
        }
    }
}
