using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CollegeProgram
{
      public abstract class CollegeIDCard
    {
        private string _name, _id;
        private int _phone;

        public CollegeIDCard(string name, string id)
        {

            this._id = id;
            this._name = name;

        }
        public CollegeIDCard(string name, string id, int phone) : this(name, id)
        {

            this._phone = phone;

        }
    }

}


