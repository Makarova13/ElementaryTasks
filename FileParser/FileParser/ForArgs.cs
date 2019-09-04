using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using UserInterface;

namespace FileParser
{
    class ForArgs
    {
        public static void WorkWithArgs(string[] args)
        {
            ConsoleUI ui = new ConsoleUI();
            FileParser fileParser;

            if (args.Length == 0 || args.Length > 3)
            {
                throw new FormatException(Constants.INFO);
            }

            if (!File.Exists(args[0]))
            {
                throw new FileNotFoundException(Constants.ERROR_FILE_DOESNT_EXIST);
            }

            if (args.Length == 2)
            {
                fileParser = new FileCounter(args[0], args[1]);
                new Application(ui, fileParser);
            }

            if (args.Length == 3)
            {
                fileParser = new FileReplacer(args[0], args[1], args[2]);
                new Application(ui, fileParser);
            }
        }

    }
}
