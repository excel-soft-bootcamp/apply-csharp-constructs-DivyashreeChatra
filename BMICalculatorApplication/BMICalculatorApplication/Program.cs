using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BMICalculatorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int height= ConsoleDisplayLib.ConsoleDisplayLibType.GetUserHeight();
            int weight = ConsoleDisplayLib.ConsoleDisplayLibType.GetUserWeight();

            int result=BMICalculatorLib.BMICalculatorType.CalculateBMIResult(height,weight);
            string total =ValidateLib.ValidateType.BMIValidate(result);
           
            Console.WriteLine(total);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
