using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksHelper;

namespace Envelope
{
    class EnvelopeFromConsole: IEnvelopeCreate
    {
        public Envelope CreateEnvelope()
        {
            float a = GetFloat(StringConsts.ENTER_LENGTH);
            float b = GetFloat(StringConsts.ENTER_WIDTH);

            return new Envelope(a, b);
        }

        private float GetFloat(string mes)
        {
            while (true)
            {
                if (!float.TryParse(ConsoleUI.ReadLine(), out float a))
                {
                    ConsoleUI.ShowMessage(StringConsts.WRONG_FORMAT_ERROR);
                }
                else if (!Validator.IsPositive(a))
                {
                    ConsoleUI.ShowMessage(StringConsts.NEGATIVE_NUM_ERROR);
                }
                else
                {
                    return a;
                }
            }
        }
    }
}
