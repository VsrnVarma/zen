using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1
{
    public class Student
    {
        public int StudId { get; set; }
        string SName;
        public string Dob { get; set; }

        public string Name
        {
            get { return SName; }
            set { SName = value; }
        }

        public Student() { }

        public Student(string name, string dob)
        {
            SName = name;
            Dob = dob;
        }

        public Student(int id, string dob, string name)
        {
            StudId = id;
            Dob = dob;
            SName = name;
        }
    }

    class Info
    {
        public static void Display(Student stu)
        {
            Console.WriteLine($"ID of student: {stu.StudId} , Name: {stu.Name} and DOB: {stu.Dob}");
        }
    }
}
