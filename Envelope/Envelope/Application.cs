using System;
using NLog;
using UserInterface;
using Validator;

namespace Task2Envelope
{
    class Application
    {
        #region properties

        private EnvelopeCreator Creator { get; set; }
        private Messages Message { get; set; }
        private IUserInterface UI { get; }
        private IArgsValidator ValidatorArgs { get; }
        private INumsValidator ValidatorNums { get; }
        private ILogger Logger { get; }

        #endregion

        public Application(IUserInterface ui, ILogger logger,
            IArgsValidator validatorArgs, INumsValidator validatorNums)
        {
            UI = ui;          
            ValidatorArgs = validatorArgs;
            ValidatorNums = validatorNums;
            Logger = logger;
        }

        public void Run(string[] args)
        {
            Logger.Info(Messages.Started);
            Message = new Messages();
            Creator = new EnvelopeCreator(ValidatorNums, ValidatorArgs);

            if (args.Length == 4 && ValidatorArgs.ArgsAreFloat(args))
            {
                CheckEnvelopes(args[0], args[1], args[2], args[3]);
            }
            else
            { 
                UI.ShowMessage(Messages.Instruction);
                UI.AskContinue(Messages.StartConsole);
            }

            while (UI.WannaContinue)
            {
                UI.Clear();
                UI.ShowMessage(Messages.ConsoleIntruction);
                CheckEnvelopes(UI.ReadLine(), UI.ReadLine(),
                               UI.ReadLine(), UI.ReadLine());
            }
        }

        private void CheckEnvelopes(string side1en1, string side2en1, 
                                    string side1en2, string side2en2)
        {
            try
            {
                Envelope en1 = Creator.CreateEnvelope(side1en1, side2en1);
                Envelope en2 = Creator.CreateEnvelope(side1en2, side2en2);

                Outcomes outcome = en1.TryPutIn(en2);
                UI.ShowMessage(Message.OutcomeMessage[outcome]);

                UI.AskContinue(Messages.Continue);
            }
            catch (FormatException ex)
            {
                Logger.Error(ex, ex.Message);
                UI.ShowMessage(ex.Message);
                UI.AskContinue(Messages.Continue);
            }
        }
    }
}
