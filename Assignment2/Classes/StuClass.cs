﻿using System;
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
