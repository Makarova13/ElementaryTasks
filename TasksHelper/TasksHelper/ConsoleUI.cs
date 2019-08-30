using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksHelper
{
    public class ConsoleUI: IUserInterface
    {
        public bool WannaContinue { get; set; }

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

        public static bool GetMinAndMax(out int min, out int max)
        {
            min = 0;
            max = 0;

            return int.TryParse(Console.ReadLine(), out min) && int.TryParse(Console.ReadLine(), out max);
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
