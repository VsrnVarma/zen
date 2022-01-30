Write a program in C# Sharp to declare a structure called Books with a property, a method to display the value of Book_id, and a private field called Book_id (int


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    class Program
    {
        public struct Books
        {
            private int Book_id;

            public int ID
            {
                get { return Book_id; }
                set { Book_id = value; }
            }

            public void DisplayID(int id)
            {
                Console.WriteLine("Id of the book: " + id);
            }
        }

        static void Main(string[] args)
        {
            Books bk = new Books();
            bk.ID = 43;
            bk.DisplayID(bk.ID);
        }
    }
}
