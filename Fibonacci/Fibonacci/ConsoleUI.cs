using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class ConsoleUI
    {
        public static bool WannaContinue = true;

        public static void GetMinAndMax(out int min, out int max)
        {
            Console.WriteLine("Enter min and max separated by Enter: ");
            min = 0;
            max = 0;
            try
            {
                min = Convert.ToInt32(Console.ReadLine());
                max = Convert.ToInt32(Console.ReadLine());

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void AskContinue()
        {
            Console.Write("Do you want to continue? Write 'y' or 'yes' if you do.  ");
            string answ = Console.ReadLine().ToLower();

            WannaContinue = (answ.Equals("yes") || answ.Equals("y"));
        }

        public static void ShowIntList(List<int> list)
        {
            foreach (int i in list)
            {
                Console.Write("{0} ", i);
            }
        }

        public static void Clear()
        {
            Console.Clear();
        }
    }
}
