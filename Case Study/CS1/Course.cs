using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1
{
    public class Course
    {
        public int CId { get; set; }
        string Cname;
        public int Duration { get; set; }
        public long Fee { get; set; }

        public string Name
        {
            get { return Cname; }
            set { Cname = value; }
        }

        public Course() { }

        public Course(int id, string name, long fee, int dur)
        {
            CId = id;
            Fee = fee;
            Cname = name;
            Duration = dur;
        }
    }

    class CInfo
    {
        public static string Display(Course c)
        {
            return $"ID of course: {c.CId} , Name: {c.Name} is for a time of {c.Duration} weeks which costs: {c.Fee}";
        }
    }
}
