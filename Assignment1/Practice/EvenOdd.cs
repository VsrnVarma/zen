using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class EvenOdd
    {
        static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());

            if (num%2==0)
            {
                Console.WriteLine("Given number is even.");
            }
            else
            {
                Console.WriteLine("Given number is odd.");
            }
        }
        
    }
}
