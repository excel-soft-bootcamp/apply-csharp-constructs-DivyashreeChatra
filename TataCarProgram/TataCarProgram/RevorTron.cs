using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TataCarProgram
{
     class RevorTron : IEngine
    {
      public  void Start()
        {
            Console.WriteLine("RevorTron Start");
        }
        public void Stop()
        {
            Console.WriteLine("RevorTron Stop");
        }
    }
}
