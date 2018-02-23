using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public delegate void NameChangedDelegate(string existingName, string newName);
    public delegate void AverageDelegate(float existingAve, float newAve);
}
