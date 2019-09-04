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
            char[] buf;
            int startPosition = 0;
            byte[] bytes;

            FileStream file = new FileStream(Parser.Path, FileMode.Open, FileAccess.Read);
            BufferedStream br = new BufferedStream(file);

            while (startPosition < file.Length)
            {
                buf = new char[count];
                bytes = new byte[count];

                if (count > (file.Length - startPosition)) 
                {
                    count = (int)file.Length - startPosition;
                }

                br.Read(bytes, 0, count);
                buf = Encoding.UTF8.GetString(bytes).ToCharArray();

                Parser.ParsePiece(new string(buf));

                startPosition += count;
            }
            br.Dispose();
            file.Dispose();

            Parser.FinishWork();

            UI.ShowMessage(Parser.ToString());
            UI.Pause();
        }
    }
}
