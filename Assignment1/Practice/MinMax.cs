using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class MinMax
    {
        static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int min = Math.Min(a, Math.Min(b, c));
            int max = Math.Max(a, Math.Max(b, c));

            Console.WriteLine("Smallest number:" + min);
            Console.WriteLine("Largest number:" + max);

            /*if(a>b && a > c)
            {
                Console.WriteLine("Largest number:" + a);
            }
            else if (b > c)
            {
                Console.WriteLine("Largest number:" + b);

                if (c > a)
                    Console.WriteLine("Smallest number:" + a);
                else
                    Console.WriteLine("Smallest number:" + c);

            }
            else
            {
                Console.WriteLine("Largest number:" + c);

                if (b > a)
                    Console.WriteLine("Smallest number:" + a);
                else
                    Console.WriteLine("Smallest number:" + b);
            }*/
    
        }
    }
}
