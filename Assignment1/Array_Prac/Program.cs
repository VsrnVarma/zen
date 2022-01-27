using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Prac
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = { 5,40,26,10,37};
            float sum = 0.0f;
            int min = marks[0];
            int max = marks[0];

            foreach(var item in marks)
            {
                sum += item;
                if (item < min)
                    min = item;
                if (item > max)
                    max = item;
            }

            Console.WriteLine("Average of array elements:" + (sum / marks.Length));
            Console.WriteLine("Smallest element of array:" + min);
            Console.WriteLine("Largest element of array:" + max); 
        }
    }
}
