using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Prac
{
    class Array_Marks
    {
        static void Main()
        {
            float sum = 0.0f;
            float avg;
            float[] arr = new float[10];
            Console.WriteLine("Enter the marks:");


            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Marks{0}", i + 1);
                arr[i] = Convert.ToSingle(Console.ReadLine());
            }

            float min = arr[0], max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (arr[i] < min)
                    min = arr[i];
                if (arr[i] > max)
                    max = arr[i];
            }
            avg = sum / arr.Length;

            Console.WriteLine("Total:"+sum);
            Console.WriteLine("Average:"+avg);
            Console.WriteLine("Min:{0} Max:{1}",min,max);

            Array.Sort(arr);
            Console.WriteLine("Ascending Order------");
            Console.WriteLine(string.Join(",",arr));
   
            Array.Reverse(arr);
            Console.WriteLine("Descending Order------");
            Console.WriteLine(string.Join(",", arr));
        }
    }
}
