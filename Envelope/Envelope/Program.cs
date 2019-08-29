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
            do
            {
                ConsoleUI.Clear();

                Envelope en1 = EnvelopeUI.CreateEnvelopeFromConsole(StringConsts.FIRST_ENVELOPE);
                Envelope en2 = EnvelopeUI.CreateEnvelopeFromConsole(StringConsts.SECOND_ENVELOPE);

                en1.CanPutInEnvelope += ConsoleUI.ShowMessage;
                en1.CanPutIn(en2);

                ConsoleUI.AskContinue(StringConsts.CONTINUE);

                en1.CanPutInEnvelope -= ConsoleUI.ShowMessage;

            } while (ConsoleUI.WannaContinue);          
        }
    }
}
