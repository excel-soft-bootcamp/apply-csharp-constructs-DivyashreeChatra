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
            int repeatableCount = 3;
            do
            {
                string displayMessage = $"Enter Your Choice {(int)Options.Console}->ConsoleInput,{(int)Options.File}->FileInput";
                ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay(displayMessage);
                try
                {
                    int choice = Int32.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        float height = ConsoleInputReaderLib.ConsoleInputReaderType.GetUserHeight();
                        float weight = ConsoleInputReaderLib.ConsoleInputReaderType.GetUserWeight();
                        float bmivalue = BMICalculateLib.CalculateBMIValueType.BmiCalculation(weight, height);
                        string message = BMIValueValidateLib.ValidateBMIValueType.ValidateBMIValue(bmivalue);
                        ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay("Result is : " + height + "\t" + weight + "\t" + bmivalue + "\t\t" + message);
                        repeatableCount = 0;
                    }
                    else if (choice == 2)
                    {
                        ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay("enter path");
                        string enteredPath = Console.ReadLine();
                        ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay(@"Entered path is " + (string)enteredPath);
                        InputFileReaderLib.FileReaderType.Input(enteredPath);
                        repeatableCount = 0;
                    }
                    else
                    {
                        ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay("Invalid Input");
                    }
                }

                catch (FormatException)
                {
                    ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay("Choice must be number");
                }
                --repeatableCount;
            } while (repeatableCount > 0);
        }
    }
}