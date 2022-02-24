using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    class Employee
    {
        public int EmployeeID;
        public string FirstName, LastName, Title, City;
        public DateTime Dob, Doj;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> EmpList = new List<Employee>
            {
                new Employee()
                {
                    EmployeeID= 1001,
                    FirstName= "Malcolm",
                    LastName= "Daruwalla",
                    Title= "Manager",
                    Dob= DateTime.Parse("16/11/1984"),
                    Doj= DateTime.Parse("8/6/2011"),
                    City="Mumbai"
                },

                new Employee()
                {
                    EmployeeID= 1002,
                    FirstName= "Asdin",
                    LastName= "Dhalla",
                    Title= "AsstManager",
                    Dob= DateTime.Parse("20/08/1984"),
                    Doj= DateTime.Parse("7/7/2012"),
                    City="Mumbai"
                },

                new Employee()
                {
                    EmployeeID= 1003,
                    FirstName= "Madhavi",
                    LastName= "Oza",
                    Title= "Consultant",
                    Dob= DateTime.Parse("14/11/1987"),
                    Doj= DateTime.Parse("12/4/2015"),
                    City="Pune"
                },

                new Employee()
                {
                    EmployeeID= 1004,
                    FirstName= "Saba",
                    LastName= "Shaikh",
                    Title= "SE",
                    Dob= DateTime.Parse("3/6/1990"),
                    Doj= DateTime.Parse("2/2/2016"),
                    City="Pune"
                },

                new Employee()
                {
                    EmployeeID= 1005,
                    FirstName= "Nazia",
                    LastName= "Shaikh",
                    Title= "SE",
                    Dob= DateTime.Parse("8/3/1991"),
                    Doj= DateTime.Parse("2/2/2016"),
                    City="Mumbai"
                },

                new Employee()
                {
                    EmployeeID= 1006,
                    FirstName= "Amit",
                    LastName= "Pathak",
                    Title= "Consultant",
                    Dob= DateTime.Parse("7/11/1989"),
                    Doj= DateTime.Parse("8/8/2014"),
                    City="Chennai"
                },

                new Employee()
                {
                    EmployeeID= 1007,
                    FirstName= "Vijay",
                    LastName= "Natrajan",
                    Title= "Consultant",
                    Dob= DateTime.Parse("2/12/1989"),
                    Doj= DateTime.Parse("1/6/2015"),
                    City="Mumbai"
                },

                new Employee()
                {
                    EmployeeID= 1008,
                    FirstName= "Rahul",
                    LastName= "Dubey",
                    Title= "Associate",
                    Dob= DateTime.Parse("11/11/1993"),
                    Doj= DateTime.Parse("6/11/2014"),
                    City="Chennai"
                },

                new Employee()
                {
                    EmployeeID= 1009,
                    FirstName= "Suresh",
                    LastName= "Mistry",
                    Title= "Associate",
                    Dob= DateTime.Parse("12/8/1992"),
                    Doj= DateTime.Parse("3/12/2014"),
                    City="Chennai"
                },

                new Employee()
                {
                    EmployeeID= 1010,
                    FirstName= "Sumit",
                    LastName= "Shah",
                    Title= "Manager",
                    Dob= DateTime.Parse("12/4/1991"),
                    Doj= DateTime.Parse("2/1/2016"),
                    City="Pune"
                }

            };

            //1 Display detail of all the employee
            //var q1 = from d in EmpList
            //           select d;
            //foreach(var item in q1)
            //{
            //    Console.WriteLine($"ID: {item.EmployeeID}, FirstName: {item.FirstName}, LastName: {item.LastName}");
            //    Console.WriteLine($"Title: {item.Title}, City: {item.City}");
            //    Console.WriteLine($"DOB: {item.Dob}, DOJ: {item.Doj}\n");
            //}

            //2 Display details of all the employee whose location is not Mumbai
            //var q2 = from q in EmpList
            //         where q.City == "Mumbai"
            //         select q;
            //foreach (var item in q2)
            //{
            //    Console.WriteLine($"ID: {item.EmployeeID}, FirstName: {item.FirstName}, LastName: {item.LastName}");
            //    Console.WriteLine($"Title: {item.Title}, City: {item.City}");
            //    Console.WriteLine($"DOB: {item.Dob}, DOJ: {item.Doj}\n");
            //}

            //3 Display details of all the employee whose title is AsstManager
            //var q3 = from q in EmpList
            //         where q.Title == "AsstManager"
            //         select q;
            //foreach (var item in q3)
            //{
            //    Console.WriteLine($"ID: {item.EmployeeID}, FirstName: {item.FirstName}, LastName: {item.LastName}");
            //    Console.WriteLine($"Title: {item.Title}, City: {item.City}");
            //    Console.WriteLine($"DOB: {item.Dob}, DOJ: {item.Doj}\n");
            //}

            //4 Display details of all the employee whose Last Name start with S
            //var q4 = from q in EmpList
            //         where q.LastName.StartsWith("S")
            //         select q;
            //foreach (var item in q4)
            //{
            //    Console.WriteLine($"ID: {item.EmployeeID}, FirstName: {item.FirstName}, LastName: {item.LastName}");
            //    Console.WriteLine($"Title: {item.Title}, City: {item.City}");
            //    Console.WriteLine($"DOB: {item.Dob}, DOJ: {item.Doj}\n");
            //}

            //5 Display a list of all the employee who have joined before 1/1/2015
            //var q5 = from q in EmpList
            //         where q.Doj < DateTime.Parse("1/1/2015")
            //         select q;
            //foreach (var item in q5)
            //{
            //    Console.WriteLine($"ID: {item.EmployeeID}, FirstName: {item.FirstName}");
            //    Console.WriteLine($"DOJ: {item.Doj}\n");
            //}

            //6 Display a list of all the employee whose date of birth is after 1/1/1990
            //var q6 = from q in EmpList
            //         where q.Dob > DateTime.Parse("1/1/1990")
            //         select q;
            //foreach (var item in q6)
            //{
            //    Console.WriteLine($"ID: {item.EmployeeID}, FirstName: {item.FirstName}");
            //    Console.WriteLine($"DOJ: {item.Dob}\n");
            //}

            //7 Display a list of all the employee whose designation is Consultant and Associate
            //var q7 = from q in EmpList
            //         where q.Title=="Consultant" || q.Title=="Associate"
            //         select q;
            //foreach (var item in q7)
            //{
            //    Console.WriteLine($"ID: {item.EmployeeID}, FirstName: {item.FirstName}");
            //    Console.WriteLine($"DOJ: {item.Title}\n");
            //}

            //8 Display total number of employees
            int q8 = (from q in EmpList
                      select q).Count();
            Console.WriteLine($"There are {q8} employees");

            //9 Display total number of employees belonging to “Chennai”
            int q9 = (from q in EmpList
                      where q.City == "Chennai"
                      select q).Count();
            Console.WriteLine($"There are {q9} employees who belong to chennai");

            //10 Display highest employee id from the list
            int q10 = (from q in EmpList
                       select q.EmployeeID).Max();
            Console.WriteLine($"There highest Employee id: {q10}\n");

            //11 Display total number of employee who have joined after 1/1/2015
            //var q11 = from q in EmpList
            //         where q.Doj > DateTime.Parse("1/1/2015")
            //         select q;
            //foreach (var item in q11)
            //{
            //    Console.WriteLine($"ID: {item.EmployeeID}, FirstName: {item.FirstName}");
            //    Console.WriteLine($"DOJ: {item.Doj}\n");
            //}

            //12 Display total number of employee whose designation is not “Associate”
            int q12 = (from q in EmpList
                       where q.Title!="Associate"
                       select q).Count();
            Console.WriteLine($"Number of Employees who are not associates: {q12}\n");

            //13 Display total number of employee based on City
            var q13=(from q in EmpList
                    group q by q.City into city
                    select city);
            foreach (var item in q13)
            {
                Console.Write($"ID: {item.Key}\t");
                Console.WriteLine($"{item.Count()}");
            }
            Console.WriteLine();
            //14 Display total number of employee based on city and title
            var q14 = (from q in EmpList
                       group q by (q.City,q.Title) into city
                       orderby city.Key
                       select city);
            foreach (var item in q14)
            {
                Console.Write($"ID: {item.Key}\t");
                Console.WriteLine($"{item.Count()}");
            }
            Console.WriteLine();

            //15 Display total number of employee who is youngest in the list
            var q15 =  from q in EmpList
                       where q.Dob==((from d in EmpList select d.Dob).Max())
                       select q;
            foreach(var item in q15)
                Console.WriteLine($"Youngest Employee: {item.FirstName} born on {item.Dob}");   
        }
    }
}
