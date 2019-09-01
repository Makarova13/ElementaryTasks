﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsWithNums
{
    public static class StringArrayExtentions
    {
        public static bool GetInt(this string[] str, int arrLength, int startIndex, out int[] arrInt)
        {
            arrInt = new int[arrLength];
            if (arrLength != str.Length - startIndex)
            {
                return false;
            }

            for (int i = 0, j = startIndex; i < arrLength; i++, j++)
            {
                if (!int.TryParse(str[j], out arrInt[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool GetInt(this string[] str, out int[] arrInt)
        {
            arrInt = new int[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                if (!int.TryParse(str[i], out arrInt[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool TryGetByteArr(this char[] str, int arrLength, out byte[] arrByte, int startIndex = 0)
        {
            arrByte = new byte[arrLength];
            if (arrLength != str.Length - startIndex)
            {
                return false;
            }

            for (int i = 0, j = startIndex; i < arrLength; i++, j++)
            {
                if (!byte.TryParse(str[j].ToString(), out arrByte[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
