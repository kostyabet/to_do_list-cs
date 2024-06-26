﻿using System.Text;

namespace to_do_list_cs 
{
    internal abstract class MainToDo
    {
        private static void PrepearProgram () 
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            Console.InputEncoding = Encoding.GetEncoding(1251);
            Console.Title = "To Do List™";
            Display.DisplayStatus(["To Do List!", "Loading..."]);
            //Tasks.LoadTasksFromFile();
            Thread.Sleep(1000);
            Display.DisplayStatus(["To Do List!", "Success"]);
            Thread.Sleep(200);
        }
        private static void WorkWithControl(MainOptions control) 
        {
            switch (control) 
            {
                case MainOptions.GetTask: Tasks.GetTask(); break;
                case MainOptions.Tasks: Tasks.WorkWithTasks(); break;
                case MainOptions.References: Display.Reference(); break;
            }
        }
        private static void MainProgram() 
        {
            MainOptions control;
            string prompt = "To Do List™";
            do 
            {
                int index = Display.GetSelectedIndex(prompt, Navigation.GetMainOptions());
                control = Navigation.MainOptionsController(index);
                WorkWithControl(control);
            } while (control != MainOptions.Exit);
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