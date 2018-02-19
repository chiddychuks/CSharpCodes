using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Gradebook
    {
        List<float> grades;
        public Gradebook()
        {
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats =  new GradeStatistics();
          
            float sum = 0;
            foreach (float gr in grades)
            {
                stats.HighestGrade = Math.Max(gr, stats.HighestGrade);
                stats.lowestGrade = Math.Max(gr, stats.lowestGrade);
                sum += gr;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
    }
}
