using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeProgram
{
    public class StudentIDCard : CollegeIDCard
    {
      
            string _dob;
            string _address;
            public StudentIDCard(string name, string id, int phone, string dob, string address) : base(id, name, phone)
            {
                this._dob = dob;
                this._address = address;

            }
        }

    }

