﻿namespace ToDoList 
{
    class MainToDo () 
    {
        static void PrepearProgram () 
        {
            Display.DisplayStatus(["To Do List!", "Loading..."]);
            Tasks.LoadTasksFromFile();
            Thread.Sleep(1000);
            Display.DisplayStatus(["To Do List!", "Success"]);
            Thread.Sleep(200);
        }
        public static void MainProgram() 
        {
            var control = MainOptions.EXIT;
            string prompt = "Choose varient";
            do 
            {
                int Index = Display.getSelectedIndex(prompt, Navigation.GetMainOptions());
                control = Navigation.MainOptionsController(Index);
            } while (control != MainOptions.EXIT);
        }
        private static void ExitProcess() 
        {
            Display.DisplayStatus(["To Do List!", "Wait..."]);
            //Tasks.SaveTasksInFile();
            Thread.Sleep(1000);
            Display.DisplayStatus(["To Do List!", "Success"]);
            Thread.Sleep(200);
            Display.DisplayStatus(["To Do List!", "GoodBye"]);
            Thread.Sleep(200);
            Console.Clear();
        }
        public static void Main(String[] args) 
        {
            PrepearProgram();
            MainProgram();
            ExitProcess();
        }
    }
}