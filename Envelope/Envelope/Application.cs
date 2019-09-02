using System.Collections.Generic;
using UserInterface;
using Validator;

namespace Envelope
{
    class Application
    {       
        private EnvelopeCreator creator;

        private NumValidator validator;

        public Application(IUserInterface ui)
        {
            UI = ui;
            creator = new EnvelopeCreator(UI);
            validator = new NumValidator();
        }

        public IUserInterface UI { get; }

        public void Run(string[] args)
        {
            Envelope en1;
            Envelope en2;

            if (args.Length == 4 && validator.ArgsAreFloat(args))
            {
                en1 = creator.CreateEnvelope(args[0], args[1]);
                en2 = creator.CreateEnvelope(args[2], args[3]);

                CheckEnvelopes(en1, en2);
            }
            else
            {
                UI.ShowMessage(StringConsts.INSTRUCTION);
            }

            while (UI.WannaContinue)
            {
                UI.Clear();

                UI.ShowMessage(StringConsts.FIRST_ENVELOPE);
                en1 = creator.CreateEnvelope();

                UI.ShowMessage(StringConsts.SECOND_ENVELOPE);
                en2 = creator.CreateEnvelope();

                CheckEnvelopes(en1, en2);
            }
        }

        private void CheckEnvelopes(Envelope en1, Envelope en2)
        {
            en1.CanPutInEnvelope += UI.ShowMessage;
            en1.CanPutIn(en2);

            UI.AskContinue(StringConsts.CONTINUE);

            en1.CanPutInEnvelope -= UI.ShowMessage;
        }
    }
}
