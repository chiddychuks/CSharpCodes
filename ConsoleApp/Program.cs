using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //String name = Console.ReadLine();
            //    Console.WriteLine("Hi " + name + ". Please enter the hours of sleep");
            //    int number = int.Parse(Console.ReadLine());
            //    if (number > 10)
            //    {
            //        Console.WriteLine("You are getting enough sleep. Thank you");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You need enough sleep biko");
            //    }
            Gradebook gr = new Gradebook();
            gr.AddGrade(23);
            gr.AddGrade(89);
            gr.AddGrade(45);
            GradeStatistics stats = gr.ComputeStatistics();
            Console.WriteLine("Average score is: " + stats.AverageGrade);
            Console.WriteLine("Lowest score is: " + stats.lowestGrade);
            Console.WriteLine("highest score is: " + stats.HighestGrade);
        }
    }
    
}
