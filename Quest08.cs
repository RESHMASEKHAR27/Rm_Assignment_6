using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rm_Assignments_6
{
    class Employee
    {
        public string Name { get; set; }
        public string Designation { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Designation: {Designation}";
        }
    }
    class Quest08
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>();

            // Accepting employee details from the user
            Console.WriteLine("Enter employee details :");

            while (true)
            {
                Console.Write("Enter employee name: ");
                string name = Console.ReadLine();

                if (name.ToLower() == "exit")
                    break;

                Console.Write("Enter employee designation: ");
                string designation = Console.ReadLine();

                
                employees.Add(new Employee { Name = name, Designation = designation });
            }

           
            List<string> order = new List<string> 
            { "Program Manager", "Project Manager", "Team Lead", "Senior Programmer", "Junior Programmer" };
            List<Employee> sortedEmployees = employees.OrderBy(e => order.IndexOf(e.Designation)).ToList();

            
            Console.WriteLine("\nOrganized Employee Details:");

            foreach (var employee in sortedEmployees)
            {
                Console.WriteLine(employee);
            }

            Console.ReadLine(); 
        }
    }
}
