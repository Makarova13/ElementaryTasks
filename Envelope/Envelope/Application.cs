using System;
using NLog;
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
        private ILogger Logger { get; set; }

        public Application(IUserInterface ui, ILogger logger,
            IArgsValidator validatorArgs, INumsValidator validatorNums)
        {
            UI = ui;
            creator = new EnvelopeCreator(validatorNums, validatorArgs, logger);
            ValidatorArgs = validatorArgs;
            ValidatorNums = validatorNums;
            Logger = logger;
        }

        public void Run(string[] args)
        {
            Logger.Info(StringConsts.STARTED);

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
                CheckEnvelopes(UI.ReadLine(), UI.ReadLine(),
                               UI.ReadLine(), UI.ReadLine());
            }
        }

        private void CheckEnvelopes(string side1, string side2, 
                                    string side3, string side4)
        {
            try
            {
                Envelope en1 = creator.CreateEnvelope(side1, side2);
                Envelope en2 = creator.CreateEnvelope(side3, side4);

                Outcomes outcome = en1.CheckPutIn(en2);
                UI.ShowMessage(StringConsts.Messeges[outcome]);

                UI.AskContinue(StringConsts.CONTINUE);
            }
            catch (FormatException ex)
            {
                Logger.Error(ex, ex.Message);
                UI.ShowMessage(ex.Message);
                UI.AskContinue(StringConsts.CONTINUE);
            }
        }
    }
}
