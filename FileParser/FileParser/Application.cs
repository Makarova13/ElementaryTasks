using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface;
using System.IO;

namespace FileParser
{
    class Application
    {
        public IUserInterface UI { get; }
        private FileParser Parser { get; set; }

        public Application(IUserInterface ui, FileParser parser)
        {
            UI = ui;
            Parser = parser;
            Run();
        }

        private void Run()
        {
            string str = string.Empty;
            string toSearch = string.Empty;

            int count = 256;
            char[] buf = new char[count];
            int startPosition = 0;

            FileStream file = new FileStream(Parser.Path, FileMode.Open);
            BinaryReader br = new BinaryReader(file);

            while (startPosition < file.Length)
            {
                if (count > (file.Length - startPosition)) 
                {
                    count = (int)file.Length - startPosition;
                }

                br.Read(buf, startPosition, count);

                Parser.ParsePiece(new string(buf));
                startPosition += count;
            }

            br.Dispose();
            file.Dispose();

            UI.ShowMessage(Parser.ToString());
            UI.Pause();
        }
    }
}
