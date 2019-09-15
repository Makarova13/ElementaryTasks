using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTicket
{
    public class Messages
    {
        #region messages

        public const string EnterPath = "Please enter path to the file with algorithm:";
        public const string EnterMin = "Please enter minimum ticket number:";
        public const string EnterMax = "Please enter maximum ticket number:";

        #endregion

        #region errors

        public const string ErrorFormat = "Min and Max must contain only digits.";
        public readonly static string ErrorDigitsNumber = $"The ticket must have {Ticket.NumberLength} characters.";
        public const string ErrorWrongPath = "Wrong path.";
        public const string ErrorNoAlgorithm = "The first line of file must be the type of ticket('Piter' or 'Moskow')";

        #endregion

        #region Logger messages

        public const string Started = "Application started";
        public const string TicketsAnalyser = "Tickets analyser created. Algorythm: ";
        public const string MoskowAlgorithm = "Moskow ticket algorithm has been chosen.";
        public const string PiterAlgorithm = "Piter ticket algorithm has been chosen.";

        #endregion

    }
}
