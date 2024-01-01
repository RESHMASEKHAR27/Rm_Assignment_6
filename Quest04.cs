using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rm_Assignments_6
{
    internal class Quest04 
    { 
        static void Main() 
        {
            ArrayList Students = new ArrayList() { "RESHMA", "VEENA", "ANAND"};
            // Students.Add("Reshma");
            // Students.Add("Veena");
            //Students.Add("Anand");



            Console.WriteLine("Descending order of Student Names:");

            Students.Sort();
            Students.Reverse(); 

            foreach(var student in Students)
            {
                Console.WriteLine(student);
            }

        }
    }
}
