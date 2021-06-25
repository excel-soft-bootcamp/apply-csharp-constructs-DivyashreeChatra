using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIProgram
{
    class Validate
    {
        MessageDisplay obj3 = new MessageDisplay();
        public void BMIValidate(int bmivalue)
        {
            if (bmivalue < 18.5)
            {
                obj3.Underweight();
            }
            else if (bmivalue >= 18.5 && bmivalue <= 25)
            {
                obj3.Normal();
            }
            else if (bmivalue > 25)
            {
                obj3.Overweight();
            }
        }
    }
}
