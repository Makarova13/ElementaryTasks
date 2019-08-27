using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksHelper
{
    public class Validator
    {
        public static bool TryGetDouble(string message, out double a)
        {
            Console.WriteLine(message);

            return double.TryParse(Console.ReadLine(), out a);           
        }

        public static bool IsPositive(double a)
        {
            return a >= 0.0;
        }
    }
}
