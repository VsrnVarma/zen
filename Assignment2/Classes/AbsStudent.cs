Create an Abstract class Student with  Name, StudentId, Grade as members 
and also an abstract method Boolean Ispassed(grade) which takes grade as an input and checks whether student passed the course or not.  
Create 2 Sub classes Undergraduate and Graduate that inherits all members of the student and overrides Ispassed() method 
For the UnderGrad class, if the grade is above 70.0, then isPassed returns true, otherwise it returns false. For the Grad class, 
if the grade is above 80.0, then isPassed returns true, otherwise false.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    abstract class Students
    {
        string StdName;
        int Id;
        double Grade;
        
        public Students(string name,int id)
        {
            StdName = name;
            Id = id;
        }

        public void Show()
        {
            Console.WriteLine($"Name: {StdName} ID: {Id}");
        }

        abstract public bool IsPassed(double grade);
    }

    class Undergraduate : Students
    {

        public Undergraduate(string n,int i) : base(n, i)
        {
        } 

        public override bool IsPassed(double g)
        {
            if (g > 70)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Graduate : Students
    {

        public Graduate(string n, int i) : base(n, i)
        {
        }
        public override bool IsPassed(double grad)
        {
            if (grad > 80)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class AbsStudent
    {
        

        static void Main()
        {
            Students st;
            
            st = new Undergraduate("Rajesh",560);
            st.Show();
            Console.Write("Enter the Grade: ");
            double grade = Convert.ToDouble(Console.ReadLine());
            Console.Write("Result of the student: ");
            bool result=st.IsPassed(grade);
            Console.WriteLine(result ? "Passed" : "Failed");

            st = new Graduate("Dheeraj",568);
            st.Show();
            Console.Write("Enter the Grade: ");
            double g = Convert.ToDouble(Console.ReadLine());
            Console.Write("Result of the student: ");
            bool res=st.IsPassed(g);
            Console.WriteLine(res ? "Passed" : "Failed");
        }
    }
}
