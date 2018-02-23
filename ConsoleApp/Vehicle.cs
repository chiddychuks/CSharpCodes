using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Vehicle : IDrivable
    {
        public Vehicle(string brand = "No brand ",int wheel = 0, int speed = 0)
        {
            Brand = brand;
            Wheels = wheel;
            Speed = speed;
        }
        public int Wheels { get; set; }
        public int Speed { get; set; }
        public string Brand { get; set; }

        public void Move()
        {
            Console.WriteLine($"The brand is {Brand} has {Wheels} wheels and it moves at the speed of {Speed} MPH");   
        }

        public void Stop()
        {
            Console.WriteLine($"The brand {Brand} stops");
            Speed = 0;
        }
    }
}
