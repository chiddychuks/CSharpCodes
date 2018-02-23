using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    interface IDrivable
    {
        int Wheels { get; set; }
        int Speed { get; set; }
        void Move();
        void Stop(); 

    }
}
