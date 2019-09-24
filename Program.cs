using System;
using ToDo.domain;

namespace ToDo
{
    class Program
    {
        
        static Task[] taskList = new Task[100];

        static void Main(string[] args)
        {

            bool shouldRun = true;
            int taskIdCounter = 1;
            while (shouldRun)
            {
                Console.Clear();

                Console.WriteLine("1. add todo");
                Console.WriteLine("2. list todo");
                Console.WriteLine("3. Exit");

                ConsoleKeyInfo keypressed = Console.ReadKey(true);

                Console.Clear();

                switch (keypressed.Key)
                {

                    case ConsoleKey.D1:
                        Console.Write("Title :");
                        string title = Console.ReadLine();

                        Console.Write("Due Time (yyyy-mm-dd hh:mm):");
                        DateTime dueTime = DateTime.Parse(Console.ReadLine());

                        taskList[GetIndexPosition()] = new Task(taskIdCounter, title, dueTime);
                        break;


                    case ConsoleKey.D2:

                        Console.WriteLine("ID         Title           Due date            Completed     ");
                        Console.WriteLine("----------------------------------------------------------");

                        foreach (var task in taskList)
                        {
                            if (task == null) continue;
                            Console.WriteLine($"{task.Id} {task.Title}{task.DueDate.ToString().PadLeft(25, ' ')}");
                        }
                        Console.ReadKey(true);

                        //Console.WriteLine();
                        //Console.WriteLine("(M)ark as completed");
                        //keypressed = Console.ReadKey(true);
                        //switch (keypressed.Key)
                        //{
                        //    case ConsoleKey.M:

                        //        break;

                        //}

                        break;

                    case ConsoleKey.D3:

                        shouldRun = false;

                        break;
                }
            }
        }
        static int GetIndexPosition()
        {
            int result = -1;
            for (int i = 0; i < taskList.Length; i++)
            {
                if (taskList[i] != null)
                {
                    continue;
                }
                if (taskList[i] == null)
                {
                    result = i;
                    break;
                }
                if (result == -1)
                {
                    throw new Exception("No avalible position");
                }
            }
            return result;
        }
    }
}
