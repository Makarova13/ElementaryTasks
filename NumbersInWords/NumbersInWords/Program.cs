using Assistant;

namespace NumbersInWords
{        
    class Program
    {
        static void Main(string[] args)
        {
            if (args.CheckNumberOfArgs())
            {
                UI.ShowMessageWithNewLine(Settings.INSTRUCTION);
                Assistant.Helper.Saybye();
                return;
            }
            Validator.CheckInt(args[0]);
            UI.ShowMessageWithNewLine(Helper.ConvertWithPower(args[0]));

            Assistant.Helper.Saybye();

        }
    }
}
