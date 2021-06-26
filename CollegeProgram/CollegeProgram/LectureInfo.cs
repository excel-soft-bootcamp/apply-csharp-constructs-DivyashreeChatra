using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeProgram
{
        class LectureInfo : CollegeInfo
        {
            private string _department;
            public LectureInfo(string name, string id, int phone, string department) : base(id, name, phone)
            {
                this._department = department;
            }

        }

    }

