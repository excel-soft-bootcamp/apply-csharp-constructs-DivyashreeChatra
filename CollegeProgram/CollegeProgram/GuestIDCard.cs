using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeProgram
{
        class GuestIDCard : CollegeIDCard
    {
            private string _dateOfVisit;
            public GuestIDCard(string name, string id, string dateOfVisit) : base(id, name)
            {
                this._dateOfVisit = dateOfVisit;
            }
        }
    }

