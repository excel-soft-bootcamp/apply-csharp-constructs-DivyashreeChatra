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
            StudentIDCard _student = new StudentIDCard("Ranga", "Excel23", 98484848, "30 / 05 / 1997", "kuvempunagar");
            LectureIDCard _lecture = new LectureIDCard("Raghu", "L456", 90876454, "Mathematics");
            StaffIDCard _staff = new StaffIDCard("Rama", "Staf23", 87898765, "Non-IT", "Cleaning");
            GuestIDCard _guest = new GuestIDCard("Ravi", "Guest101", "27/06/2021");
            Console.ReadLine();
        }
      
    }
}
