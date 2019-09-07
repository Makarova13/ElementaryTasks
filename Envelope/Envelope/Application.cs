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
            creator = new EnvelopeCreator(validatorNums, validatorArgs);
            ValidatorArgs = validatorArgs;
            ValidatorNums = validatorNums;
        }

        public void Run(string[] args)
        {
            if (args.Length == 4 && ValidatorArgs.ArgsAreFloat(args))
            {
                CheckEnvelopes(args[0], args[1], args[2], args[3]);
            }
            else
            {
                UI.ShowMessage(StringConsts.INSTRUCTION);
                UI.AskContinue(StringConsts.START_CONSOLE);
            }

            while (UI.WannaContinue)
            {
                UI.Clear();
                UI.ShowMessage(StringConsts.CONSOLE_INSTRUCTION);
                CheckEnvelopes(UI.ReadLine(), UI.ReadLine(), UI.ReadLine(), UI.ReadLine());
            }
        }

        private void CheckEnvelopes(string side1, string side2, string side3, string side4)
        {
            Envelope en1;
            Envelope en2;

            try
            {
                en1 = creator.CreateEnvelope(side1, side2);
                en2 = creator.CreateEnvelope(side3, side4);

                en1.EnvelopeChecked += UI.ShowMessage;

                en1.CheckPutIn(en2);
                UI.AskContinue(StringConsts.CONTINUE);

                en1.EnvelopeChecked -= UI.ShowMessage;

            }
            catch (FormatException ex)
            {
                UI.ShowMessage(ex.Message);
                UI.AskContinue(StringConsts.CONTINUE);
            }
        }
    }
}
