using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeProgram
{
        class GuestIDCard : CollegeIDCard
    {
            private string _employeement_type;
            public GuestIDCard(string name, string id, string employeement_type) : base(id, name)
            {
                this._employeement_type = employeement_type;
            }
        }
    }

