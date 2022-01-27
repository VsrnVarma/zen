using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string1: ");
            string str = Console.ReadLine();
            Console.Write("Enter string2: ");
            string str2 = Console.ReadLine();

            Console.WriteLine("Length of the string1: "+str.Length);

            bool v = str.Equals(str2);
            if (v)
            {
                Console.WriteLine("Both strings are equal");
            }
            else
            {
                Console.WriteLine("Both strings are not equal");
            }

            char[] arr = str.ToCharArray();
            string rev = " ";
            for(int i = arr.Length-1; i >= 0; i--)
            {
                rev = rev + arr[i];
            }

            Console.WriteLine("Reverse of a string1: "+rev);
        }
    }
}
