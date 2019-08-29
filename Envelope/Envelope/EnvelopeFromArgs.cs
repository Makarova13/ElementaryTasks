using System;
using TasksHelper;

namespace Envelope
{
    class EnvelopeFromArgs : IEnvelopeCreate
    {
        public string[] TwoArgs { get; }

        public EnvelopeFromArgs(string args1, string args2)
        {
            TwoArgs = new string[] { args1, args2 };
        }

        public Envelope CreateEnvelope()
        {
            return new Envelope(int.Parse(TwoArgs[0]), int.Parse(TwoArgs[1]));  
        }
    }
}
