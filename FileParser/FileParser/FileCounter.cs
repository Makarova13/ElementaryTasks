using System;
using System.IO;

namespace FileParser
{
    class FileCounter : FileParser
    {
        public FileCounter(string path, string pattern)
            :base(path, pattern)
        {        }

        public int Counter { get; private set; } = 0;

        public override void ParsePiece(string text)
        {
            int patternLen = Pattern.Length;
            int textLen = text.Length;

            int[] badChar = new int[256];

            BadCharHeuristic(Pattern, patternLen, ref badChar);

            int s = 0;
            while (s <= (textLen - patternLen))
            {
                int j = patternLen - 1;

                while (j >= 0 && Pattern[j] == text[s + j])
                    --j;

                if (j < 0)
                {
                    Counter++;
                    s += (s + patternLen < textLen) ? patternLen - badChar[text[s + patternLen]] : 1;
                }
                else
                {
                    s += Math.Max(1, j - badChar[text[s + j]]);
                }
            }
        }

        public override string ToString()
        {
            string str = string.Format($"Occurs of {Pattern}: {Counter}");
            return str;
        }
    }
}
