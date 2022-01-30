Write a program in C# Sharp to insert the information of two books. 

Test Data :

Insert the information of two books :                    
-----------------------------------------                
Information of book 1 :                                  
Input name of the book : BASIC                           
Input the author : S.TROELSTRA                           
                                                         
Information of book 2 :                                  
Input name of the book : C+                              
Input the author : G.RTRTG   

                            
Expected Output:

1: Title = BASIC,  Author = S.TROELSTRA                  
                                                         
2: Title = C+,  Author = G.RTRTG


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    struct Book
    {
        public string Name;
        public string Author;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book[] bk = new Book[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Information of book {i + 1}");
                Console.Write("Input name of the book: ");
                bk[i].Name = Console.ReadLine();
                Console.Write("Input the author: ");
                bk[i].Author = Console.ReadLine();
                Console.WriteLine();
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"{i + 1}: Title = {bk[i].Name}, Author = {bk[i].Author}");
            }
            
        }
    }
}
