using ArifmCalc.Models;
using System;
using System.Text;

namespace ArifmCalc.Services
{
    internal class InputManager
    {
        public static CalcModel InputData()
        {
            var cm = new CalcModel();
            try
            {
                Console.WriteLine("\n First number:");
                cm.A = Convert.ToDouble(Console.ReadLine());
                if (cm.A != (double)cm.A)
                    throw new Exception("\n Wrong input");

                Console.WriteLine("\n Operation:");
                cm.S = Convert.ToString(Console.ReadLine());
                if (cm.S != "+" && cm.S != "-" && cm.S != "*" && cm.S != "/")
                    throw new Exception("\n Wrong input");

                Console.WriteLine("\n Second number:");
                cm.B = Convert.ToDouble(Console.ReadLine());
                if (cm.B != (double)cm.B)
                    throw new Exception("\n Wrong input");
                cm.IsCorrect = true;
            }
            catch (Exception ex)
            {
                cm.IsCorrect = false;
                Console.WriteLine($"\n Mistake:\n {ex.Message}");
            }
            return cm;

        }

    }
}
