using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeProgram
{
   
        class StaffInfo : CollegeInfo
        {
            private string _kindOfWork;
            public StaffInfo(string name, string id, int phone, string department, string kindOfWork) : base(id, name, phone)
            {

                this._kindOfWork = kindOfWork;

            }
        }
    }
