using System;

using Assistant;

namespace NumbersInWords
{
    static class Validator
    {
        public static void CheckInt(string tmp)
        {
            int result;
            if (!int.TryParse(tmp, out result))
            {
                UI.ShowMessageWithNewLine(Settings.WRONG_DATA);
                Assistant.Helper.Saybye();
                Environment.Exit(0);
            }
            if (result > 1999999999)
            {
                UI.ShowMessageWithNewLine(Settings.BIG);
                Assistant.Helper.Saybye();
                Environment.Exit(0);
            }

        }

        public static bool CheckNumberOfArgs(this string[] args)
        {
            if (args.Length > 2)
            {
                UI.ShowMessageWithNewLine(Settings.WRONG_NUMBER_OF_ARGS);
                Assistant.Helper.Saybye();
                Environment.Exit(0);
            }
            return args.Length == 0;
        }
    }
}
