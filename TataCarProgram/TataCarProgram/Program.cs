using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TataCarProgram
{
    public class TataCarProgram
    {
        public static void Main(string[] args)
        {
            TATACar Car = new TATACar(new DiCorEngine());
            Car.Drive();
            Car.Halt();
            TATACar multijetengine = new TATACar(new MultiJetEngine());
            multijetengine.Drive();
            multijetengine.Halt();
            TATACar revorTron = new TATACar(new RevorTron());
            revorTron.Drive();
            revorTron.Halt();
            Console.ReadLine();
        }
    }
}

