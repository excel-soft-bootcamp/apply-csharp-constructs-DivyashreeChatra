using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeProgram
{
    class Program
    {
        static void Main()
        {
            StudentInfo _student = new StudentInfo("Ranga", "Excel23", 98484848, "30 / 05 / 1997", "kuvempunagar");
            LectureInfo _lecture = new LectureInfo("Raghu", "L456", 90876454, "Mathematics");
            StaffInfo _staff = new StaffInfo("Rama", "Staf23", 87898765, "Non-IT", "Cleaning");
            GuestInfo _guest = new GuestInfo("Ravi", "Guest101", 90878765, "Substitute Teacher");
            Console.ReadLine();
        }
      
    }
}
