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
            String name = Console.ReadLine();
            Console.WriteLine("Hi "+ name + ". Please enter the hours of sleep");
            int number = int.Parse( Console.ReadLine());
            if (number > 10)
            {
                Console.WriteLine("You are getting enough sleep. Thank you");
            }
            else
            {
                Console.WriteLine("You need enough sleep biko");
            }
            
           
        }
    }
}
