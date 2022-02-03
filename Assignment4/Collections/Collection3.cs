using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class Student
    {
        int Sid;
        string SName;
        double Marks;

        public Student(int id, string name, double marks)
        {
            Sid = id;
            SName = name;
            Marks = marks;
        }

        public override string ToString()
        {
            return $"Student Id: {Sid} Name: {SName} scored: {Marks}";
        }
    }

    class Collection3
    {
        static void Main(string[] args)
        {
            List<Student> stu = new List<Student>();
            stu.Add(new Student(10, "Ashraf", 66.5));
            stu.Add(new Student(05, "Sreeram", 78.0));
            stu.Add(new Student(16, "Rahul", 70.0));

            foreach (Student s in stu)
            {
                Console.WriteLine(s.ToString());
            }

            Console.WriteLine("-------Array List-------");
            ArrayList alist = new ArrayList();
            alist.Add(24);
            alist.Add("Good");
            alist.Add(456.89);
            alist.Add(30.4f);
            foreach(var item in alist)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------Hash Table-------");
            Hashtable ht = new Hashtable();
            ht.Add("S01", "Varma");
            ht.Add("S02","Yogesh");
            foreach(DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key+" "+d.Value);
            }

            Console.WriteLine("--------Dictionary--------");
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(20, "Sreeram");
            dict.Add(19, "Dheeraj");
            foreach (KeyValuePair<int,string> d in dict)
            {
                Console.WriteLine(d.Key + " " + d.Value);
            }

            Console.WriteLine("--------Sorted List--------");
            SortedList slist = new SortedList();
            slist.Add(26, "Sreeram");
            slist.Add(29, "Dheeraj");
            slist.Add(10, "Moses");
            foreach (var item in slist.Values)
            {
                Console.WriteLine(item);
            }

        }
    }
}