1.	Write a program in C# to accept a word from the user and display the length of it.
2.	Write a program in C# to accept a word from the user and display the reverse of it. 
3.	Write a program in C# to accept two words from user and find out if they are same.

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
