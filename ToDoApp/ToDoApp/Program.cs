using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
          //  args = new string[]{ "-a", "dog" };
            if (args.Length == 0)
            {
                Console.WriteLine("Command Line Todo application \n" +
                                "=============================");
                Console.WriteLine();
                Console.WriteLine("Command line arguments: \n" +
                                    "-l   Lists all the tasks \n" +
                                    "-a   Adds a new task \n" +
                                    "-r   Removes an task \n" +
                                    "-c   Completes an task");

                Console.ReadLine();
            }
            else if (args.Contains("-l")) 
            {
                string path = @"../../todo-list.txt";
               
                try
                {
                    string[] content = File.ReadAllLines(path);
                    int count = 1;
                    if (content.Length == 0)
                    {
                       Console.WriteLine("lucky you, there is no task for today");
                    }
                    else
                    {
                        foreach (string task in content)
                        { 
                            Console.WriteLine(count++ + " - " + task);
                        }    
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Uh-oh, could not read the file!");
                }
                Console.ReadLine();
            }
            else if (args.Contains("-a"))
            {
                string path = @"../../todo-list.txt";
                try
                {
                  // using (StreamWriter taskwriter = new StreamWriter(path))
                  using (StreamWriter taskwriter = File.AppendText(path))
                   {
                        taskwriter.WriteLine(args[1]);
                        
                   }
                }
                catch (Exception)
                {
                    Console.WriteLine("Unable to write file: todo-list.txt. Add new task in between quotation marks!"); 
                }
                

            }
            //using (StreamWriter writer = new StreamWriter(path))
            //{
            //    writer.WriteLine("walk the dog");
            //}
        }
    }
}

