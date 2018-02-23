using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
   public class GradeStatistics
    {
        public GradeStatistics()
        {
            HighestGrade = 0;
            lowestGrade = float.MaxValue;
        }
        public float AverageGrade = 0.0f; 
        public float HighestGrade; 
        public float lowestGrade;  
    }
}
