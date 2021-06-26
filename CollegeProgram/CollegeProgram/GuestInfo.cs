using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeProgram
{
   
        class GuestInfo : CollegeInfo
        {
            private string _employeement_type;
            public GuestInfo(string name, string id, int phone  , string employeement_type) : base(id, name, phone)
            {
                this._employeement_type = employeement_type;
            }
        }
    }

