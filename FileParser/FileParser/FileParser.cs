using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileParser
{
    abstract class FileParser
    {
        public FileParser(string path, string pattern)
        {
            Path = path;
            Pattern = pattern.ToCharArray();
        }

        public string Path { get; private set; }
        protected char[] Pattern { get; set; }

        public abstract void ParsePiece(string text);          // Boyer-Moore

        protected static void BadCharHeuristic(char[] str, int size, ref int[] badChar)
        {
            int i;

            for (i = 0; i < 256; i++)
                badChar[i] = -1;

            for (i = 0; i < size; i++)
                badChar[(int)str[i]] = i;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
