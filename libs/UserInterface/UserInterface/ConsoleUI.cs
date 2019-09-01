using System;
using System.Collections.Generic;

namespace UserInterface
{
    public class ConsoleUI : IUserInterface
    {
        public bool WannaContinue { get; set; } = true;

        public void AskContinue(string str)
        {
            Console.Write(str);
            string answ = Console.ReadLine().ToLower();

            WannaContinue = (answ.Equals("yes") || answ.Equals("y"));
        }

        public void ShowMessage(string m)
        {
            Console.WriteLine(m);
        }

        public void ShowNum(int m)
        {
            Console.Write(m);
        }

        public void Show(string m)
        {
            Console.Write(m);
        }

        public void ShowIntList(List<int> list)
        {
            Console.WriteLine(string.Join<int>(",", list));
        }

        public void Clear()
        {
            Console.Clear();
        }

        public void ShowCollection<T, K>(T col) where T : IEnumerable<K>
        {
            foreach (K i in col)
            {
                Console.WriteLine(i.ToString());
            }
        }

        public void Pause()
        {
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public string[] ReadLine(char c)
        {
            return Console.ReadLine().Split(c);
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
