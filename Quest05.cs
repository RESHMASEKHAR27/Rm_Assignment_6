using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rm_Assignments_6
{
    internal class Quest05
    {
        static void Main()
        {
            SortedDictionary<int,string> EmployeeDetails = new SortedDictionary<int,string>();

            EmployeeDetails.Add(1,"RESHMA");
            EmployeeDetails.Add(2, "Meenu");
            EmployeeDetails.Add(3, "Nila");
            EmployeeDetails.Add(4,"Krish");

            Console.WriteLine("EmployeeDetails in Sorted order:");

            foreach(var Employee in EmployeeDetails)
            {
                Console.WriteLine($"Employee code: {Employee.Key}, Employee Name: {Employee.Value}");
            }



        }
    }
}
