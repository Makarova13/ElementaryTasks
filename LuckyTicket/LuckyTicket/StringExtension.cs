using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTicket
{
    public static class StringExtension
    {
        public static int[] StringToIntArray(this string str)
        {
            try
            {
                return str.Split().Select(n => Convert.ToInt32(n)).ToArray();
            }
            catch (FormatException)
            {
                throw new FormatException(Messages.ERROR_FORMAT);
            }           
        }
    }
}
