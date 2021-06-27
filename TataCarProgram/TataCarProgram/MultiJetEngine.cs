using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TataCarProgram
{
    public class MultiJetEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("MultiJetEngine Start");
        }
        public void Stop()
        {
            Console.WriteLine("MultiJetEngine Stop");
        }
    }
}
