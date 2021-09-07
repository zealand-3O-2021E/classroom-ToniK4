using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class ClassRoom
    {
        public string ClassName { get; set; }
        public List<Student> ClassList { get; set; }
        public DateTime SemesterStart { get; set; }

        public ClassRoom()
        {
            
        }

        public void SeasonCount()
        {
            int winterCounter = 0;
            int springCounter = 0;
            int summerCounter = 0;
            int autumnCounter = 0;
            foreach (var Student in ClassList)
            {
                if (Student.Season() == "Winter")
                {
                    winterCounter += 1;
                }
                if (Student.Season() == "Spring")
                {
                    springCounter += 1;
                }
                if (Student.Season() == "Summer")
                {
                    summerCounter += 1;
                }
                if (Student.Season() == "Autumn")
                {
                    autumnCounter += 1;
                }

            }
            Console.WriteLine("Winter birthdays: "+ winterCounter);
            Console.WriteLine("Spring birthdays: "+ springCounter);
            Console.WriteLine("Summer birthdays: "+ summerCounter);
            Console.WriteLine("Autumn birthdays: "+ autumnCounter);

        }
    }
}
