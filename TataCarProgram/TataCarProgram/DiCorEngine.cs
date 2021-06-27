using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TataCarProgram
{
    public class DiCorEngine : IEngine
    {

        public void Start()
        {
            Console.WriteLine("DiCorEngine Start");
        }
        public void Stop()
        {
            Console.WriteLine("DiCorEngine Stop");
        }
    }
}
