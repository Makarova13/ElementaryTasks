using UserInterface;
using Validator;

namespace Envelope
{
    class EnvelopeCreator
    {
        public EnvelopeCreator(IUserInterface ui)
        {
            UI = ui;
        }

        private IUserInterface UI { get; set; }

        public Envelope CreateEnvelope(string arg1, string arg2)  //get envelope from args
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
            NumValidator validator = new NumValidator();

            while (true)
            {
                if (!float.TryParse(UI.ReadLine(), out float result))
                {
                    UI.ShowMessage(StringConsts.WRONG_FORMAT_ERROR);
                }

                else if (!validator.IsPositive(result))
                {
                    UI.ShowMessage(StringConsts.NEGATIVE_NUM_ERROR);
                }

                else
                {
                    return result;
                }
            }
        }
    }
}
