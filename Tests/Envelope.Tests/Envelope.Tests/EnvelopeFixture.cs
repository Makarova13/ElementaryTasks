using Validator;

namespace Task2Envelope.Tests
{
    public class EnvelopeFixture
    {
        private IArgsValidator argsValidator;
        private INumsValidator numsValidator;
        public EnvelopeCreator Creator { get; private set; }

        public EnvelopeFixture()
        {
            argsValidator = new ArgsValidator();
            numsValidator = new NumsValidator();
            Creator = new EnvelopeCreator(numsValidator, argsValidator);
        }
    }
}
