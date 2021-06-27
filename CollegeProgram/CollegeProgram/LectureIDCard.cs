using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeProgram
{
        class LectureIDCard : CollegeIDCard
    {
            private string _department;
            public LectureIDCard(string name, string id, int phone, string department) : base(id, name, phone)
            {
                this._department = department;
            }

        }

    }

