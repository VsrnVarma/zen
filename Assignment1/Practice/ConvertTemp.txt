using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class ConvertTemp
    {
        static void Main()
        {
            Console.WriteLine("Enter the temperature:");
            double fah=Convert.ToDouble(Console.ReadLine());

            double cel = (fah - 32) * 5 / 9;
            Console.WriteLine($"The temperature in celsius: {cel}");
        }
    }
}
