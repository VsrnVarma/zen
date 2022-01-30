Create an Interface IStudent with StudentId and Name as Properties, ShowDetails() as its method. 
Create 2 classes Dayscholar and Resident that implements the interface Properties and Methods. Test The functionalities.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    interface IStudent
    {
        int StudentId { get; set; }
        string Name { get; set; }

        void ShowDetails(int id,string name);
    }

    class Dayscholar:IStudent
    {
        private int StuId;

        public string Name { get; set; }

        public int StudentId
        {
            get { return StuId; }
            set { StuId = value; }
        }

        public void ShowDetails(int id,string name)
        {
            Console.WriteLine("The details of dayscholar student is:");
            Console.WriteLine($"ID: {id} and Name: {name}");
        }
    }

    class Hostel : IStudent
    {
        private int StuId;
        public string Name { get; set; }

        public int StudentId
        {
            get { return StuId; }
            set { StuId = value; }
        }

        public void ShowDetails(int id,string name)
        {
            Console.WriteLine("The details of residential student is:");
            Console.WriteLine($"ID: {id} and Name: {name}");
        }
    }

    class InterfaceEg
    {
        static void Main()
        {
            IStudent ds = new Dayscholar();
            ds.StudentId = 571;
            ds.Name = "Sreeram";
            ds.ShowDetails(ds.StudentId,ds.Name);
            IStudent hs = new Hostel();
            hs.StudentId = 584;
            hs.Name = "Kowshik";
            hs.ShowDetails(hs.StudentId, hs.Name);
        }
    }
}
