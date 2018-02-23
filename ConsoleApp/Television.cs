using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Television : IElectronicDevice
    {
        public int Volume { get; set; } = 0;
        public void Off()
        {
            Console.WriteLine("The Tv is Off");
        }

        public void On()
        {
            Console.WriteLine("The Tv is On");
        }

        public void VolumeDown()
        {
            if (Volume != 0 )
            {
                Volume--;
            } Console.WriteLine($"The volume is at {Volume}");
        }

        public void VolumeUp()
        {
            if (Volume != 100)
            {
                Volume++;
            }
            Console.WriteLine($"The volume is at {Volume}");
        }
    }
}
