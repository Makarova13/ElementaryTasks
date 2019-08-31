using System.Collections.Generic;

namespace UserInterface
{
    public interface IUserInterface
    {
        bool WannaContinue { get; set; }

        void AskContinue(string str);
        void ShowMessage(string m);
        void ShowIntList(List<int> list);
        void Clear();
        void ShowCollection<T, K>(T col) where T : IEnumerable<K>;
        void Pause();
        string[] ReadLine(char c);
        string ReadLine();
    }
}
