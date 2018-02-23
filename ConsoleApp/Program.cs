using System;
using System.Collections.Generic;
using System.IO;
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
            Gradebook gr = new ThrowAwayGradeBook();//bcos I inherited from the class Gradebook
            //delegates can call multiple methods and also u can multi cast or simply just add delegates by using +=
            // gr.Namechanged = new NameChangedDelegate(OnNameChanged);
            gr.Namechanged += new NameChangedDelegate(OnNameChanged);
            gr.Namechanged += new NameChangedDelegate(OnNameChanged2);
            gr.Name = "Chidi's book";
            gr.Name = "My new book";
            gr.AddGrade(23);
            gr.AddGrade(89);
            gr.AddGrade(45);
            GradeStatistics stats = gr.ComputeStatistics();
            Console.WriteLine("Average score is: " + stats.AverageGrade);
            Console.WriteLine("Lowest score is: " + stats.lowestGrade);
            Console.WriteLine("highest score is: " + stats.HighestGrade);
            using (StreamWriter output = File.CreateText(@"D:\grade.txt"))
            {
                gr.WriteGrades(output);
            }
            Vehicle mycar = new Vehicle("Benz", 4, 160);
            if (mycar is IDrivable)
            {
                mycar.Move();
                mycar.Stop();
            }
            else
            {
                Console.WriteLine($"The brand '{mycar.Brand}' cant be driven");
            }

            IElectronicDevice TV = TVRemote.GetDevice();
            PowerButton pwr = new PowerButton(TV);
            pwr.Execute();
            TV.Off();
            TV.VolumeUp();
            TV.VolumeDown();
        }

        static void OnNameChanged(string existingName, string newName)
        {
            Console.WriteLine($"Name changed from {existingName} to {newName} ");
        }

        //
        static void OnNameChanged2(string existingName, string newName)
        {
            Console.WriteLine("************ ");
        }
    }
    
}
