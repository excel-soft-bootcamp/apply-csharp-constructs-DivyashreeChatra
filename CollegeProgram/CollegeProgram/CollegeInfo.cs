using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CollegeProgram
{
    public class CollegeInfo
    {
        private string _name, _id;
        private int _phone;

        public CollegeInfo(string name)
        {
            this._name = name;
        }

        public CollegeInfo(string name, string id) : this(name)
        {

            this._id = id;

        }
        public CollegeInfo(string name, string id, int phone) : this(name, id)
        {

            this._phone = phone;

        }
    }

}


