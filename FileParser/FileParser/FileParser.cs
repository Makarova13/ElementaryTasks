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
            Pattern = pattern;
        }

        public string Path { get; private set; }
        protected string Pattern { get; set; }
        public StringBuilder Piece { get; set; }

        public abstract void ParsePiece(string text);          // Boyer-Moore

        protected static void BadCharHeuristic(string str, int size, ref int[] badChar)
        {
            int i;

            for (i = 0; i < 256; i++)
            {
                badChar[i] = -1;
            }

            for (i = 0; i < size; i++)
            {
                badChar[(int)str[i]] = i;
            }
        }

        public virtual void FinishWork()
        {        }
    }
}
