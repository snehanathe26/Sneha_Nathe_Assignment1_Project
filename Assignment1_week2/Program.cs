using System;
using System.Collections.Generic;


namespace Assignement_Week2
{
    public class Program
    {
        static List<string> tasks = new List<string>();

        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n Which Task do you want to perform: ");
                Console.WriteLine("1. Add to the Task-List");
                Console.WriteLine("2. View the Task-List");
                Console.WriteLine("3. Update the Task-List");
                Console.WriteLine("4. Delete the Task-List");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                int choice= Convert.ToInt32(Console.ReadLine());

                switch (choice)
                    {
                        case 1:
                            add_task();
                            break;
                        case 2:
                            view_task();
                            break;
                        case 3:
                        update_task();
                            break;
                        case 4:
                        delete_task();
                            break;
                        case 5:
                            exit = true;
                            Console.WriteLine("Exiting...");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                
                
            }
        }

        static void add_task()
        {
            Console.Write("Enter task title: ");
            string title = Console.ReadLine();
            tasks.Add(title);
            Console.WriteLine("Task added successfully!");
        }

        static void view_task()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
            }
            else
            {
                Console.WriteLine("\nTasks:");
               
                foreach (string task in tasks)
                {
                    Console.WriteLine(task);
                }
            }
        }

        static void update_task()
        {
            view_task();
            if (tasks.Count > 0)
            {
                Console.Write("Enter the task number to update: ");
                int index=Convert.ToInt32(Console.ReadLine());
                if (index>0 && index<tasks.Count)
                {
                    Console.Write("Enter new title: ");
                    string newTitle = Console.ReadLine();
                    tasks[index - 1] = newTitle;
                    Console.WriteLine("Task updated successfully!");
                }
                else
                {
                    Console.WriteLine("Invalid task number.");
                }
            }
        }

        static void delete_task()
        {
            view_task();
            if (tasks.Count > 0)
            {
                Console.Write("Enter the task number to delete: ");
                int index=Convert.ToInt32(Console.ReadLine());
                if (index>0 && index<tasks.Count)
                {
                    tasks.RemoveAt(index - 1);
                    Console.WriteLine("Task deleted successfully!");
                }
                else
                {
                    Console.WriteLine("Invalid task number.");
                }
            }
        }
    }
}
