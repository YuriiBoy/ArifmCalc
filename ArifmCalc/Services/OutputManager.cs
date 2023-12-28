using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArifmCalc.Services
{
    internal class OutputManager
    {
        public static void DisplayResults(double r)
        {
            Console.WriteLine($"\n Результат обчислення: {r} ");        
        }
    }
}
