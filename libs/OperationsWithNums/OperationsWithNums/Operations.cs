using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsWithNums
{
    public class Operations
    {
        public static void Swipe<T>(ref T a, ref T b)
        {
            T y = a;
            a = b;
            b = y;
        }

        public static byte[] ConvertToByteArray(int number, int length)
        {
            byte[] byteArray = new byte[length];

            for (int i = 0; i < length; i++)
            {
                byteArray[i] = (byte)(number % 10);
                number /= 10;
            }

            Array.Reverse(byteArray);
            return byteArray;
        }
    }
}
