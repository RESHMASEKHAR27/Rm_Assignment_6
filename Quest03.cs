using System.Collections;
using System.Globalization;

namespace Rm_Assignments_6
{
    internal class Quest03
    {
        static void Main(string[] args)
        {
            

            int[] numbers = new int[10];

            Console.WriteLine("Enter 10 numbers:");

            for (int i = 0; i <10; i++)
            {
                Console.Write("Number-{0}:",i);

                numbers[i] = int.Parse(Console.ReadLine());
               
            }

           Array.Sort(numbers);

            Console.WriteLine("\n Numbers sorted in Ascending order:");

            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            Console.ReadLine();





        }
    }
}