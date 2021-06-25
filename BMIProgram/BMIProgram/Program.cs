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
            ConsoleDisplay display = new ConsoleDisplay();
            int height = display.UserHeight();
            int weight = display.UserWeight();

            BMICalculator obj = new BMICalculator();
            obj.SetHeight = height;
            obj.SetWeight = weight;
            int result = obj.CalculateBMIResult();

            Validate obj1 = new Validate();
            obj1.BMIValidate(result);


            Console.ReadLine();


        }
    }
}
