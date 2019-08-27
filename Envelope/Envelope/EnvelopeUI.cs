using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksHelper;

namespace Envelope
{
    class EnvelopeUI
    {
        public static Envelope CreateEnvelope(string mes)
        {
            ConsoleUI.ShowMessage(mes);

            double a = GetDouble(StringConsts.ENTER_LENGTH);
            double b = GetDouble(StringConsts.ENTER_WIDTH);

            return new Envelope(a, b);
        }

        public static double GetDouble(string mes)
        {
            while (true)
            {
                if (!Validator.TryGetDouble(mes, out double a))
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
