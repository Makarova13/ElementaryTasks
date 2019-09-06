using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperationsWithNums;
using UserInterface;

namespace NumSequences
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleUI ui = new ConsoleUI();

            if(!args.TryGetIntArray(out int[] nums))
            {
                ui.ShowMessage(Constants.NOT_DIGITS);
                ui.Pause();
            }

            else
            {
                if(args.Length == 1)
                {
                    new Application(ui, new LessThenSquaredNum(nums[0]));
                }

                if(args.Length == 2)
                {
                    new Application(ui, new Fibonacci(nums[0], nums[1]));
                }
            }
        }
    }
}
