﻿using System;
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
                return false;
            }

            for (int i = 0, j = startIndex; i < arrLength; i++, j++) 
            {
                if(!int.TryParse(str[j], out arrInt[i]))
                {
                    return false;
                }                    
            }
            return true;
        }
    }
}
