using NLog;
using Validator;
using System;

namespace Task2Envelope
{
    public class EnvelopeCreator
    {
        private IArgsValidator ArgsValidator { get; set; }
        private INumsValidator NumsValidator { get; set; }

        public EnvelopeCreator(INumsValidator numsValidator, 
                               IArgsValidator argsValidator)
        {
            ArgsValidator = argsValidator;
            NumsValidator = numsValidator;
        }

        public Envelope CreateEnvelope(string arg1, string arg2)  
        {
            float side1 = CheckArgument(arg1);
            float side2 = CheckArgument(arg2);

            return new Envelope(side1, side2);
        }

        private float CheckArgument(string arg)
        {
            if (!float.TryParse(arg, out float result))
            {
                throw new FormatException(StringConsts.WRONG_FORMAT_ERROR);
            }

            else if (!NumsValidator.IsPositive(result))
            {
                throw new FormatException(StringConsts.NEGATIVE_NUM_ERROR);
            }

            return result;
        }
    }
}
