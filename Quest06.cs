using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Rm_Assignments_6
{


    class Bookstore
    {
        public int Bookid;
        public string Bookname;
        public override string ToString()
        {
            return $"BookId: {Bookid}, BookName: {Bookname}";
        }
    }
    internal class Quest06
    {

        static void Main()
        {

            
            Hashtable bookhashtable = new Hashtable();

            Console.WriteLine("Enter BookDetails:");


           
            for (int i=0; i<5; i++)
            {
                Console.WriteLine($"Enter details for book {i + 1}:");

                Console.Write("Enter BookId: ");

                int bookid = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter BookName: ");

                string bookName = Console.ReadLine();

                Bookstore book = new Bookstore { Bookid = bookid, Bookname = bookName };
                bookhashtable.Add(book.Bookid, book);
            }


            Console.WriteLine("Book Details:");

            foreach (DictionaryEntry entry in bookhashtable)
            {
                Bookstore book = (Bookstore)entry.Value;
                Console.WriteLine(book);
            }
            Console.ReadLine();

        }

       
    }
}
