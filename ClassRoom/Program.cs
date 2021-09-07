using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom Classroom = new ClassRoom();
            Classroom.ClassName = "3Q";
            Classroom.SemesterStart = new DateTime(2019, 08, 26);
            Classroom.ClassList.Add(new Student("Toni", 09, 03));
            Classroom.ClassList.Add(new Student("Gabor", 11, 03));
        }
    }
}
