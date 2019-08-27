using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksHelper
{
    public static class StringExtention
    {
        public static bool GetInt(this string[] str, int arrLength, int startIndex, out int[] arrInt)
        {
            arrInt = new int[arrLength];
            if(arrLength != str.Length - startIndex)
            {
                Console.WriteLine("Wrong format! Enter name and side lengths separated by commas.");
                return false;
            }

            for (int i = 0, j = startIndex; i < arrLength; i++, j++) 
            {
                if(!int.TryParse(str[j], out arrInt[i]))
                {
                    Console.WriteLine("Number {0} entered in an incorrect format.", i);
                    return false;
                }                    
            }
            return true;
        }
    }
}
