using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            BMICalulcatorConsoleInputReader display = new BMICalulcatorConsoleInputReader();
            
            BMICalculator obj = new BMICalculator();
            int result = obj.CalculateBMIResult(display.GetUserHeight(), display.GetUserWeight());

            Validate obj1 = new Validate();
            string message = obj1.BMIValidate(result);

            MessageDisplay obj2 = new MessageDisplay();
            obj2.Display(message);

            Console.ReadLine();
        }
    }
}
