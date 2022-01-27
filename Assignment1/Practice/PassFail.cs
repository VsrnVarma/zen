using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class PassFail
    {
        static void Main()
        {
            Console.WriteLine("Enter number of students:");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i<5; i++)
            {
                Console.WriteLine($"Enter the marks of the Student{i+1}");
                Console.WriteLine();
                Console.WriteLine("Enter the marks of c#");
                float s1 = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter the marks of html");
                float s2 = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter the marks of sql");
                float s3 = Convert.ToSingle(Console.ReadLine());

                double avg = (s1 + s2 + s3) / 3;
                if (avg > 50)
                {
                    Console.WriteLine("Student Passed");
                }
                else
                {
                    Console.WriteLine("Student Failed");
                }
            }
        }
    }
}
