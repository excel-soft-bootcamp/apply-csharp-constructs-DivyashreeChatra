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
            TATACar _harrier = new TATACar(new DiCorEngine());
            _harrier.Drive();
            _harrier.Halt();
            TATACar _nexon = new TATACar(new MultiJetEngine());
            _nexon.Drive();
            _nexon.Halt();
            TATACar _hexa = new TATACar(new RevorTron());
            _hexa.Drive();
            _hexa.Halt();
            Console.ReadLine();
        }
    }
}

