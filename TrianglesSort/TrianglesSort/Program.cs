using System;
using System.Collections.Generic;
using TasksHelper;


namespace TrianglesSort
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserInterface userInterface = new ConsoleUI();

            new Application(userInterface);
        }
    }
}
  