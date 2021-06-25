using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIProgram
{
    class ConsoleDisplay
    {
        public int UserHeight()
        {
            Console.WriteLine("Enter your height in meter:");
            int height = int.Parse(Console.ReadLine());
            return height;
        }

        public int UserWeight()
        {
            Console.WriteLine("Enter your weight in kg:");
            int weight = int.Parse(Console.ReadLine());
            return weight;
        }
    }
}
