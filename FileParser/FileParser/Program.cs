﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileParser
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = string.Empty;
            string toSearch = string.Empty;
            int counter = 0;

            using (StreamReader netStream = new StreamReader("iugv"))
            {
                while ((str = netStream.ReadLine()) != null)
                {
                    counter += StringSearcher.SearchString(str, toSearch).Length;
                }
            }
        }
    }
}
