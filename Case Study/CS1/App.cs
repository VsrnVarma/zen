using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1
{
    public class App
    {
        void Scenario1()
        {
            Student s1 = new Student("Harsha", "06/06/1996");
            s1.StudId = 01;
            Info.Display(s1);

            Student s2 = new Student("Sushma", "15/10/1997");
            s1.StudId = 02;
            Info.Display(s2);
        }

        void Scenario2()
        {
            Student[] Sarr = new Student[3];
            Sarr[1] = new Student(13, "01/10/1998", "Srikanth");
            Sarr[2] = new Student(14, "26/03/1996", "Sreeram");
            Sarr[0] = new Student(15, "03/05/1998", "Harshini");

            foreach (Student item in Sarr)
                Info.Display(item);
        }

        void Scenario3()
        {
            Student student = new Student();
            int NoofStudents;

            Console.Write("Enter the number of students: ");
            NoofStudents = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < NoofStudents; i++)
            {
                Console.WriteLine($"Studetn {i + 1} details:");
                Console.Write("Enter the Student name: ");
                student.Name = Console.ReadLine();
                Console.Write("Enter th ID: ");
                student.StudId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the DOB: ");
                student.Dob = Console.ReadLine();

                Info.Display(student);
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            App a1 = new App();
            //a1.Scenario1();
            a1.Scenario2();
            //a1.Scenario3();
        }
    }
}
