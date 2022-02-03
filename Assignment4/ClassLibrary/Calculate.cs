using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLibrary
{
    public class Calculate
    {
        int Age;
        int TotalFare = 500;

        public void CalculateConcession()
        {
            Console.Write("Enter age: ");

            Age = Convert.ToInt32(Console.ReadLine());

            if (Age <= 5)
            {
                Console.WriteLine("Little Champs---Free Ticket");
            }
            else if (Age > 60)
            {
                double concession = 0.3 * TotalFare;
                double cfare = TotalFare - concession;
                Console.WriteLine("Senior Citizen ticket costs"+cfare);
            }
            else
            {
                Console.WriteLine("Ticket booked which costs "+TotalFare);
            }
        } 
    }
}
