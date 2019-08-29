using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksHelper;

namespace Envelope
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 4 && Validator.ArgsAreInt(args))
            {
                IEnvelopeCreate fromArgs = new EnvelopeFromArgs(args[0], args[1]);
                Envelope en1 = fromArgs.CreateEnvelope();
                fromArgs = new EnvelopeFromArgs(args[3], args[4]);
                Envelope en2 = fromArgs.CreateEnvelope();

                en1.CanPutInEnvelope += ConsoleUI.ShowMessage;
                en1.CanPutIn(en2);

                ConsoleUI.AskContinue(StringConsts.CONTINUE);

                en1.CanPutInEnvelope -= ConsoleUI.ShowMessage;
            }
            
            IEnvelopeCreate fromConsole = new EnvelopeFromConsole();


            while (ConsoleUI.WannaContinue) ;
            {
                ConsoleUI.Clear();

                ConsoleUI.ShowMessage(StringConsts.FIRST_ENVELOPE);
                Envelope en1 = fromConsole.CreateEnvelope();

                ConsoleUI.ShowMessage(StringConsts.SECOND_ENVELOPE);
                Envelope en2 = fromConsole.CreateEnvelope();

                en1.CanPutInEnvelope += ConsoleUI.ShowMessage;
                en1.CanPutIn(en2);

                ConsoleUI.AskContinue(StringConsts.CONTINUE);

                en1.CanPutInEnvelope -= ConsoleUI.ShowMessage;
            }
        }
    }
}
