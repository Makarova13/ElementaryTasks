using System.Text;
using System.IO;
using System;

namespace FileParser
{
    class FileReplacer: FileParser, IDisposable
    {
        public FileReplacer(string path, string pattern, string forReplace)
            : base(path, pattern)
        {
            ForReplace = forReplace;
            NewFile = new FileStream(System.IO.Path.GetTempFileName(), FileMode.Create, FileAccess.Write);
        }

        private string ForReplace { get; set; }
        private FileStream NewFile { get; set; }       

        public override void ParsePiece(string text)
        {
            Piece = new StringBuilder();
            Piece.Append(text);

            Piece.Replace(Pattern, ForReplace);
            NewFile.Write(Encoding.ASCII.GetBytes(Piece.ToString()), 0, Piece.Length);
        }

        public override void FinishWork()
        {
            Dispose();
        }

        public void Dispose()
        {
            NewFile.Dispose();
            File.Replace(NewFile.Name, Path, System.IO.Path.GetTempFileName());
        }

        public override string ToString()
        {
            return Constants.REPLACED;
        }
    }
}
