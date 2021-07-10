using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSecurityApplication
{
    
    class Program
    {
        static void Main(string[] args)
        {

            SecuritySystem _observer = new SecuritySystem();
            DoorStatusHanlder _address = new DoorStatusHanlder(_observer.Notify);

            DoorSensor _subject = new DoorSensor();
            _subject.DoorStatusChanged += _address;
            _subject.Open();
            _subject.Close();

        }
    }

}