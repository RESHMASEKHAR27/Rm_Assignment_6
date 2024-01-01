using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rm_Assignments_6
{

    class Student

    {

        public int StdId { get; set; }
        public string StdName { get; set; }
        public int Age { get; set; }

        public int Std { get; set; }
        public char Section { get; set; }

        public override string ToString()
        {
            return $"StudentId: {StdId}, StudentName: {StdName}, Age: {Age}, Standard: {Std}, Section: {Section}";
        }
    }

    class Quest07
    {
        static void Main()
        {
            ArrayList studentList = new ArrayList();


            studentList.Add(new Student { StdId = 2, StdName = "Mini", Age = 8, Std = 4, Section = 'A' });
            studentList.Add(new Student { StdId = 4, StdName = "Vimal", Age = 14, Std = 9, Section = 'B' });



            Console.WriteLine("Student Details:");

            foreach (var student in studentList)
            {
                Console.WriteLine(student);
            }


        }

    }
}
