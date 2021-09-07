using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Student
    {
        public string Name { get; set; }
        public int BirthMonth { get; set; }
        public int Birthday { get; set; }

        public Student(string name, int birthMonth, int birthday)
        {
            Name = name;
            BirthMonth = birthMonth;
            Birthday = birthday;
        }

        public string Season()
        {
            if (BirthMonth == 1 || BirthMonth == 2 || BirthMonth == 12)
            {
                return "Winter";
            }
            if (BirthMonth >= 3 && BirthMonth <=5)
            {
                return "Spring";
            }
            if (BirthMonth >= 6 && BirthMonth <= 8)
            {
                return "Summer";
            }
            if (BirthMonth >= 9 && BirthMonth <= 11)
            {
                return "Autumn";
            }

            return "Birth month invalid";
        }
    }
}
