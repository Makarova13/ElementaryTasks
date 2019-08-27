using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianglesSort
{
    class ConsoleUI
    {
        public static bool WannaContinue = true;
        const int NUMBER_OF_SIDES = 3;

        public static bool GetTriangle(out string name, out int[] sides)
        {
            Console.WriteLine("Enter name and side lengths separated by commas: ");
            string input = Console.ReadLine();
            string[] triangle = input.Split(',');

            if (triangle.Length > NUMBER_OF_SIDES + 1) 
            {
                Console.WriteLine("Too many sides. Only 3 first lengths will be used.");
            }

            try
            {
                if (triangle.Length <= NUMBER_OF_SIDES)
                {
                    throw new FormatException("Wrong format. Please try again.");
                }

                sides = GetIntFromString(triangle, NUMBER_OF_SIDES, 1);
                name = triangle[0];

                return true;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                sides = new int[3];
                name = string.Empty;

                return false;
            }       
        }

        public static int[] GetIntFromString(string[] str, int arrLength, int stringStartIndex = 0)
        {
            int[] arrInt = new int[arrLength];

            for (int i = stringStartIndex, j = 0; j < arrLength; i++, j++)
            {
                try
                {
                    arrInt[j] = int.Parse(str[i]);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Number {0} entered in an incorrect format.", j);
                }
            }
            return arrInt;
        }

        public static void AskContinue(string str)   
        {
            Console.Write(str);
            string answ = Console.ReadLine().ToLower();

            WannaContinue = (answ.Equals("yes") || answ.Equals("y"));         
        }
    }
}
