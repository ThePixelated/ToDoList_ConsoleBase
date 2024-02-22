namespace testing
{
    class Program
    {
        static int maxTask = 100;
        static int maxProfile = 5;
        static string[,] tasks = new string[maxProfile, maxTask];

        static void Main(string[] args)
        {
            //Console.WriteLine(Convert.ToInt32('░'));
            
            initializeTasks();

            while (true)
            {
                addTask();
                int temp = Convert.ToInt32(tasks[0, tasks.GetLength(1) - 1]);
                Console.WriteLine(temp);
                for (int i = 0; i < temp; i++) 
                {
                    Console.WriteLine((i + 1) + ". " + tasks[0, i]);
                }

                Console.WriteLine(" ");
            }
        }

        static void addTask()
        {
            Console.Write("(+) ");
            string task = Console.ReadLine();

            tasks[0, int.Parse(tasks[0, tasks.GetLength(1) - 1])] = task;

            int indexes = int.Parse(tasks[0, tasks.GetLength(1) - 1]);
            indexes += 1;
            tasks[0, tasks.GetLength(1) - 1] = indexes.ToString();
            Console.WriteLine(tasks[0, tasks.GetLength(1) - 1]);

            // ...
        }

        static void initializeTasks()
        {
            for(int i = 0; i < maxProfile; i++)
            {
                tasks[i, tasks.GetLength(1) - 1] = "0";
            }
        }

        static void mainmenu()
        {
            Console.WriteLine("");
        }

        static void asciiTable()
        {
            for (int i = 0; i < 32; i++)
            {
                int temp = i + 32;
                for (int j = 0; j < 6; j++)
                {
                    if (temp <= 255)
                    {
                        Console.Write(temp + ": " + Convert.ToChar(temp) + "    ");
                        if (j == 1 && i + 32 < 36)
                        {
                            Console.Write(" ");
                        }
                    }
                    temp += 32;
                }
                Console.WriteLine();
            }
        }

        /*A to-do list application helps users manage their tasks and stay organized.You can develop a C# application that 
        allows users to add tasks, mark them as completed, set priorities, and set due dates. This project will give 
        you hands-on experience in handling data and implementing user interfaces

        - telor
        - ebi
        - bakso


         */
    }
}