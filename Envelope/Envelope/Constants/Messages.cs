using System.Collections.Generic;

namespace Task2Envelope
{
    public class Messages
    {
        #region messages

        public const string FirstInSec = "You can put the first envelope in the second.";
        public const string SecInFirst = "You can put the second envelope in the first.";
        public const string ConsoleIntruction = @"Enter the length and width separeted by enter.";
        public const string Continue = "Do you want to check other envelopes?  ";
        public const string NoneEnvelope = "None envelope can be put in in another.";
        public const string EqualEnvelopes = "Envelopes are equal.";
        public const string Instruction = @"To check envelopes you can start the app with their lengths and widths as arguments.
To work from console, enter the length and width separeted by enter.";
        public const string StartConsole = "Do you want to check envelopes using console?  ";

        #endregion

        #region errors

        public const string ErrorWrongFormat = "You should write a number here.";
        public const string ErrorNegativeNumber = "You should write a positive number.";
        public const string ErrorInvalidCast = "Object cannot be cast to envelope.";

        #endregion

        #region logger messages

        public const string Started = "Application started.";
        public const string CREATOR = "Envelope creator created.";

        #endregion

        #region dictionary

        public readonly Dictionary<Outcomes, string> OutcomeMessage = new Dictionary<Outcomes, string>
        {
            [Outcomes.None] = NoneEnvelope,
            [Outcomes.FirstInSecond] = FirstInSec,
            [Outcomes.SecondInFirst] = SecInFirst,
            [Outcomes.Equal] = EqualEnvelopes
        };

        #endregion
    }
}
