using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputReaderLib
{
    public class ConsoleInputReaderType
    {
        public static int GetUserHeight()
        {
            ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay("Enter your height in meter:");
            int height = int.Parse(Console.ReadLine());
            return height;
        }

        public static int GetUserWeight()
        {
            ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay("Enter your weight in kg:");
            int weight = int.Parse(Console.ReadLine());
            return weight;
        }
    }
}
