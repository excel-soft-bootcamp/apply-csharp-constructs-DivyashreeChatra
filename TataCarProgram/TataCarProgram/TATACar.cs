using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TataCarProgram
{
    public class TATACar
    {

        IEngine engine;
        public TATACar(IEngine engine)
        {
            this.engine = engine;
        }
       
        public void Drive()
        {

            engine.Start();

               
        }
        public void Halt()
        {

            engine.Stop();
        }
    }
}
