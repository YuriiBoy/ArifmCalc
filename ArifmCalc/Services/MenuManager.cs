using System;
using System.Text;

namespace ArifmCalc.Services
{
    internal class MenuManager
    {
        public static void DisplayTitle()
        {
            Console.Clear();
            Console.Write("\n ====================");
            Console.Write("\n Arifmetic Calculator");
            Console.Write("\n ====================");
            Console.WriteLine();
        }

        public static bool AllowContinue()
        {
            Console.WriteLine("\n Continue (y/n) ?:");
            string allow = Console.ReadLine();
            return (allow == "y");
        }

        public static void FinishProgram()
        {
            Console.Write("\n The program has been fineshed.\n");
        }
    }
}
