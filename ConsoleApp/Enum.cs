using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Enum
    {



        public static string GetGender(Gender gend)
        {
            switch (gend)
            {
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                case Gender.Unknown:
                    return "Unknown";
                default:
                    return "Invalid gender detected";
            }
        }
    }
    public class Customer
    {
        public int Gender { get; set; }
        public string Name { get; set; }

        public void DisplayCustomerInfo()
        {
            Console.WriteLine($"My name is {Name} and I am a {Gender}  ");

        }
    }

}

public enum Gender
{
    Male,
    Female,
    Unknown
}

