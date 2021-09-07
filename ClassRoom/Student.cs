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

        public static string Season(int birthMonth)
        {
            if (birthMonth == 1 || birthMonth == 2 || birthMonth == 12)
            {
                return "Winter";
            }
            if (birthMonth >= 3 && birthMonth <=5)
            {
                return "Spring";
            }
            if (birthMonth >= 6 && birthMonth <= 8)
            {
                return "Summer";
            }
            if (birthMonth >= 9 && birthMonth <= 11)
            {
                return "Autumn";
            }

            return "Birth month invalid";
        }
    }
}
