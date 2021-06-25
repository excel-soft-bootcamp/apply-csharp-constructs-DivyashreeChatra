using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIProgram
{
    class BMICalculator
    {
        private int height, weight, result;

        public int SetHeight
        {
            set
            {
                this.height = value;
            }
        }
        public int SetWeight
        {
            set
            {
                this.weight = value;
            }
        }

        /*  public  BMICalculator(int height,int weight)
          {
              this.height = height;
              this.weight = weight;
          }
          */
        public int CalculateBMIResult()
        {
            return result = weight / height;

        }
    }
}
