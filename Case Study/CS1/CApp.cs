using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1
{
    public class CApp
    {
        void Scenario1()
        {
            Course c1 = new Course(11, "Angular", 15000, 6);
            Console.WriteLine(CInfo.Display(c1));

            Course c2 = new Course(12, "Node", 12000, 5);
            Console.WriteLine(CInfo.Display(c2));
        }

        void Scenario2()
        {
            Course[] Carr = new Course[3];
            Carr[1] = new Course(01, "C Language", 1000, 8);
            Carr[2] = new Course(02, "C++ Language", 1000, 4);
            Carr[0] = new Course(05, "Java", 5000, 10);

            foreach (Course item in Carr)
                Console.WriteLine(CInfo.Display(item)); 
        }

        static void Main()
        {
            CApp ca = new CApp();
            //ca.Scenario1();
            ca.Scenario2();
        }
    }
}
