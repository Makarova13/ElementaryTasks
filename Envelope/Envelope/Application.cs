using System;
using UserInterface;
using Validator;

namespace Task2Envelope
{
    class Application
    {       
        private EnvelopeCreator creator;
        private IUserInterface UI { get; }
        private IArgsValidator ValidatorArgs { get; }
        private INumsValidator ValidatorNums { get; }

        public Application(IUserInterface ui, IArgsValidator validatorArgs, INumsValidator validatorNums)
        {
            UI = ui;
            creator = new EnvelopeCreator(UI, validatorNums);
            ValidatorArgs = validatorArgs;
            ValidatorNums = validatorNums;
        }

        public void Run(string[] args)
        {
            Envelope en1;
            Envelope en2;

            if (args.Length == 4 && ValidatorArgs.ArgsAreFloat(args))
            {
                en1 = creator.CreateEnvelope(args[0], args[1]);
                en2 = creator.CreateEnvelope(args[2], args[3]);

                CheckEnvelopes(en1, en2);
            }
            else
            {
                UI.ShowMessage(StringConsts.INSTRUCTION);
                UI.AskContinue(StringConsts.START_CONSOLE);
            }

            while (UI.WannaContinue)
            {
                UI.Clear();

                try
                {
                    UI.ShowMessage(StringConsts.FIRST_ENVELOPE);
                    en1 = creator.CreateEnvelope();

                    UI.ShowMessage(StringConsts.SECOND_ENVELOPE);
                    en2 = creator.CreateEnvelope();

                    CheckEnvelopes(en1, en2);
                }
                catch(FormatException ex)
                {
                    UI.ShowMessage(ex.Message);
                    UI.AskContinue(StringConsts.CONTINUE);
                }
            }
        }

        private void CheckEnvelopes(Envelope en1, Envelope en2)
        {
            en1.EnvelopeChecked += UI.ShowMessage;

            en1.CheckPutIn(en2);
            UI.AskContinue(StringConsts.CONTINUE);

            en1.EnvelopeChecked -= UI.ShowMessage;
        }
    }
}
