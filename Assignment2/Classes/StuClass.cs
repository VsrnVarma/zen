Create a class called student which has data members like rollno, name, class, SEM, branch,int [] marks=new int marks [5](marks of 5 subjects )
   -Write a method called displayresult, which should calculate the average marks
   -If marks of any one subject is less than 35 print result as failed
   -If marks of all subject is >35 but average is < 50 then also print result as failed
   -If avg > 50 then print result as passed.
   -Pass the details of student like rollno, name, class, SEM, branch in constructor
   -Write a Display Data method to display all values.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Student
    {
        int Roll;
        string Name, Class;
        int Sem;
        string Branch;

        public int[] marks = new int[5];

        public Student(int roll, string name,string cls, int sem, string branch)
        {
            Roll = roll;
            Name = name;
            Class = cls;
            Sem = sem;
            Branch = branch;
        }

        public double displayResult(int[] arr)
        {
            int sum=0;
            for(int i = 0; i < 5; i++)
            {
                sum += arr[i];
            }
            return sum / 5;
        }

        public void Display()
        {
            Console.WriteLine($"Roll No: {Roll} Name: {Name}");
            Console.WriteLine($"Class: {Class} Semester: {Sem}");
            Console.WriteLine($"Branch: {Branch}");
        }
    }

    class StuClass
    {
        static void Main()
        {
            int count = 0;

            Student std = new Student(556,"Gowtham","B",6,"CSE");
            std.Display();
            Console.Write("Enter the marks: ");

            for(int i = 0; i < 5; i++)
            {
                std.marks[i] = Convert.ToInt32(Console.Read());
            }

            double average = std.displayResult(std.marks);
            Console.Write("Result of the Student: ");

            for (int i = 0; i < 5; i++)
            {
                if (std.marks[i] < 35)
                {
                    count++;
                }
            }

            if (count == 5)
            {
                Console.WriteLine("Student Failed");
            }
            else if (average < 50 )
            {
                Console.WriteLine("Student Failed");
            }
            else
            {
                Console.WriteLine("Student Passed");
            }

        }
    }
}
