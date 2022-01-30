Write a program in C# Sharp to create a nested structure to store two data for an employee in an array. 

Test Data:

Create a nested structure and store data in an array :                              
-------------------------------------------------------                          
Name of the employee : H.Rana                                                    
Input day of the birth : 05                                                      
Input month of the birth : 02                                                    
Input year for the birth : 58                                                    
                                                                                 
Name of the employee : S.Mathur                                                  
Input day of the birth : 04                                                      
Input month of the birth : 08                                                    
Input year for the birth : 59 



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    public struct Dob
    {
        public int Day;
        public int Month;
        public int Year;
    }

    struct Employee
    {
        public string Name;
        public Dob Date;
    }

    class NestedStructure
    {
        static void Main()
        {
            
            Employee[] emp = new Employee[2];

            for (int i = 0; i < 2 ; i++)
            {
                Console.Write($"Enter The name of the employee{i+1}: ");
                string name = Console.ReadLine();
                emp[i].Name = name;
                Console.WriteLine();

                Console.WriteLine("Enter the Dob---");
                Console.Write("The day of birth: ");
                int day = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Day = day;

                Console.Write("The month of birth: ");
                int month = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Month = month;

                Console.Write("The year of birth: ");
                int year = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Year = year;
                Console.WriteLine();
            }

            /*for(int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Name of the employee{i+1}: {emp[i].Name}");
                Console.WriteLine($"Date of birth: {emp[i].Date.Day}/{emp[i].Date.Month}/{emp[i].Date.Year}");
                Console.WriteLine();
            }*/
        }
    }
}
