using ArifmCalc.Models;
using ArifmCalc.Services;
using System;
using System.Text;

namespace ArifmCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                MenuManager.DisplayTitle();
                var c = InputManager.InputData();
                if(c.IsCorrect)
                {
                    if (c.S == "+")
                    {
                        double r = CalcManager.AddCalc(c);
                        OutputManager.DisplayResults(r);
                    }
                    else if (c.S == "-")
                    {
                        double r = CalcManager.MinCalc(c);
                        OutputManager.DisplayResults(r);
                    }
                    else if (c.S == "*")
                    {
                        double r = CalcManager.MultCalc(c);
                        OutputManager.DisplayResults(r);
                    }
                    else if (c.S == "/")
                    {
                        double r = CalcManager.DivCalc(c);
                        OutputManager.DisplayResults(r);
                    }

                }

            } while (MenuManager.AllowContinue());
            
            MenuManager.FinishProgram();
        }
    }
}
