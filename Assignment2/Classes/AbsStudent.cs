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
