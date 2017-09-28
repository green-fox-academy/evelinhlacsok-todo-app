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
            Console.WriteLine("Command Line Todo application \n" +
                                "=============================");
            Console.WriteLine();
            Console.WriteLine("Command line arguments: \n" +
                                "-l   Lists all the tasks \n" +
                                "-a   Adds a new task \n" +
                                "-r   Removes an task \n" +
                                "-c   Completes an task");
                              
            Console.ReadLine();

            string path = @"../../todo-list.txt";
            try
            {
                string[] content = File.ReadAllLines(path);
                foreach (var task in content)
                {
                    Console.WriteLine(task);
                }
               
            }
            catch (Exception)
            {
                Console.WriteLine("Uh-oh, could not read the file!");
            }
            Console.ReadLine();

            //using (StreamWriter writer = new StreamWriter(path))
            //{
            //    writer.WriteLine("walk the dog");
            //}
        }


       
    }
}

