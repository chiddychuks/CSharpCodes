using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ThrowAwayGradeBook : Gradebook
    {
        public GradeStatistics ComputeStatistics()
        {
            float lowest = float.MaxValue;
            foreach (var item in grades)
            {

            }
            return base.ComputeStatistics();
        }
    }
}
