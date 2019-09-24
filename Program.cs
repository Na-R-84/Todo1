using System;

namespace ToDo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shouldRun = true;
            while (shouldRun)
            {
                Console.Clear();

                Console.WriteLine("1. add todo");
                Console.WriteLine("2. list todo");
                Console.WriteLine("3. Exit");

                ConsoleKeyInfo keypressed = Console.ReadKey(true);

                switch (keypressed.Key)
                {

                    case ConsoleKey.D1:

                        break;
                }
            }
        }
    }
}
