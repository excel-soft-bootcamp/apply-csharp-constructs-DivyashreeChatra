using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeProgram
{
   
        class StaffIDCard : CollegeIDCard
    {
            private string _employeementType;
            public StaffIDCard(string name, string id, int phone, string department, string employeementType) : base(id, name, phone)
            {

                this._employeementType = employeementType;

            }
        }
    }
