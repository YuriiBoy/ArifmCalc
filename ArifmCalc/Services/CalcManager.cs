using ArifmCalc.Models;
using System;
using System.Text;

namespace ArifmCalc.Services
{
    internal class CalcManager
    {
        public static double AddCalc(CalcModel cm)
        {
            return cm.A + cm.B;
        }
        public static double MinCalc(CalcModel cm)
        {
            return cm.A - cm.B;
        }
        public static double MultCalc(CalcModel cm)
        {
            return cm.A * cm.B;
        }
        public static double DivCalc(CalcModel cm)
        {
            return cm.A / cm.B;
        }
    }
}
