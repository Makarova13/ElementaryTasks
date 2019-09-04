using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileParser
{
    class FileReplacer: FileParser
    {
        public FileReplacer(string path, string pattern, string forReplace)
            : base(path, pattern)
        {
            ForReplace = forReplace;
        }

        private string ForReplace { get; set; }

        public override void ParsePiece(string text)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(text);

            stringBuilder.Replace(text, ForReplace);
        }


    }
}
