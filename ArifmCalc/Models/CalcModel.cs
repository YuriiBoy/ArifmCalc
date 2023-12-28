using System;
using System.Text;

namespace ArifmCalc.Models
{
    internal class CalcModel
    {
        public double A { get; set; }
        public double B { get; set; }
        public string S { get; set; }
        public bool IsCorrect { get; set; }

        public override string ToString()
        {
            return "\n Input data and result:\n" + 
                $"  {A}\n" +
                $"  {S}\n" +
                $"  {B}\n";
        }

    }
}
