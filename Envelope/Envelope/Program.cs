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
            Envelope.CanPutInEnvelope  += ConsoleUI.ShowMessage;

            do
            {
                ConsoleUI.Clear();

                Envelope en1 = EnvelopeUI.CreateEnvelope(StringConsts.FIRST_ENVELOPE);
                Envelope en2 = EnvelopeUI.CreateEnvelope(StringConsts.SECOND_ENVELOPE);
                en1.CanPutIn(en2);

                ConsoleUI.AskContinue(StringConsts.CONTINUE);

            } while (ConsoleUI.WannaContinue);          
        }
    }
}
