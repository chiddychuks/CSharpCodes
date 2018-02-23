using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Gradebook
    {
        //public string Name; --> // without the implementation of a property here
        public string _name;
        public string Name {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    Namechanged(_name, value);
                    _name = value;
                }
            }
        }

        public NameChangedDelegate Namechanged;
       protected List<float> grades;
        public Gradebook()
        {
            _name = "Empty";
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("Hey am here!");
            GradeStatistics stats =  new GradeStatistics();
          
            float sum = 0;
            foreach (float gr in grades)
            {
                stats.HighestGrade = Math.Max(gr, stats.HighestGrade);
                stats.lowestGrade = Math.Min(gr, stats.lowestGrade);
                sum += gr;
            }

            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public void WriteGrades(TextWriter destination)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                destination.WriteLine(grades[i]);
            }
        }
        public AverageDelegate aveDelegate;

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
    }
}
