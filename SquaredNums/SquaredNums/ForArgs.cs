using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksHelper;

namespace SquaredNums
{
    class ForArgs
    {
        #region error messages

        const string WRONG_FORMAT = "Wrong format!";
        const string HELP_MESSAGE = "This program displays a series of natural numbers, the square of which is less than the given n. You should write n.";
        const string TOO_MANY_ARGS = "You should write only one number.";

        #endregion

        public static void CheckAndAddArgs(string [] str)
        {         
            if (str.Length == 0)
            {
                ConsoleUI.ShowMessage(HELP_MESSAGE);
            }
            if(str.Length > 1)
            {
                ConsoleUI.ShowMessage(TOO_MANY_ARGS);
            }
            else if (int.TryParse(str[0], out int n))
            {
                Squared.FillTheList(n);
                ConsoleUI.ShowIntList(Squared.nums);
            }
            else
            {
                ConsoleUI.ShowMessage(WRONG_FORMAT);
            }
        }
    }
}
