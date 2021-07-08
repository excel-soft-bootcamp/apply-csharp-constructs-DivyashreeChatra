using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BMICalculatorApplication
{
    public class Program
    {
        public static int choiceValue;

        public enum Options
        {
            Console, File
        }
        public static void Main(string[] args)
        {
            ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay("Enter Your Choice");

            do
            {
                string displayMessage = $"{(int)Options.Console}->Console Input,{(int)Options.File}->File Input";
                Console.WriteLine(displayMessage);
                try
                {
                    int choiceValue = Int32.Parse(Console.ReadLine());
                    if (choiceValue >= 2)
                    {
                        ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay("Invalid Input");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (FormatException ex)
                {
                    ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay("Choice must be a Number");
                }

            } while (true);

            if (choiceValue == 0)
            {

                float height = ConsoleInputReaderLib.ConsoleInputReaderType.GetUserHeight();
                float weight = ConsoleInputReaderLib.ConsoleInputReaderType.GetUserWeight();

                float bmiValue = BMICalculateLib.CalculateBMIValueType.BmiCalculation(weight, height);
                string message = BMIValueValidateLib.ValidateBMIValueType.ValidateBMIValue(bmiValue);
                ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay(message);
            }
            else
            {
                ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay("Enter The File Path");
                
            }
        }
        
    }
}