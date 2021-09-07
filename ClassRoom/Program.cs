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
            Classroom.ClassList = new List<Student>();

            Classroom.ClassName = "3Q";
            Classroom.SemesterStart = new DateTime(2019, 08, 26);
            Classroom.ClassList.Add(new Student("Toni", 09, 03));
            Classroom.ClassList.Add(new Student("Gabor", 11, 03));

            Console.WriteLine("Class Name: " + Classroom.ClassName);
            Console.WriteLine("Semester Start: " + Classroom.SemesterStart);
            
            foreach (Student Student in Classroom.ClassList)
            {
                Console.WriteLine();
                Console.WriteLine("Student Name: " + Student.Name);
                Console.WriteLine("Student Birth Month: " + Student.BirthMonth);
                Console.WriteLine("Student Birthday: " + Student.Birthday);
            }
        }
    }
}
