using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSecurityApplication
{
    public delegate void DoorStatusHanlder(string status);

        public class DoorSensor
        {
            public event DoorStatusHanlder DoorStatusChanged;
            string doormovement;

        public void Open()
        {
             doormovement = "Door is Open";
            this.Notify();

        }
        public void Close()
        {
             doormovement = "Door is Closed";
            this.Notify();
        }

        void Notify()
        {
            string message = $"{this.doormovement} and Time : {System.DateTime.Now.ToString()}";
            DoorStatusChanged.Invoke(message);
        }
    }
 }
   

