using UserInterface;
using Validator;
using System;

namespace Task2Envelope
{
    public class EnvelopeCreator
    {
        private IUserInterface UI { get; set; }
        private INumsValidator Validator { get; set; }

        public EnvelopeCreator(IUserInterface ui, INumsValidator validator)
        {
            UI = ui;
            Validator = validator;
        }

        public Envelope CreateEnvelope(string arg1, string arg2)     //get envelope from args
        {
            return new Envelope(float.Parse(arg1), float.Parse(arg2));
        }

        public Envelope CreateEnvelope()      //get envelope from console
        {
            float a = GetFloat(StringConsts.ENTER_LENGTH);
            float b = GetFloat(StringConsts.ENTER_WIDTH);

            return new Envelope(a, b);
        }

        private float GetFloat(string mes)
        {
            if (!float.TryParse(UI.ReadLine(), out float result))
            {
                throw new FormatException(StringConsts.WRONG_FORMAT_ERROR);
            }

            else if (!Validator.IsPositive(result))
            {
                throw new FormatException(StringConsts.NEGATIVE_NUM_ERROR);
            }

            else
            {
                return result;
            }         
        }
    }
}
