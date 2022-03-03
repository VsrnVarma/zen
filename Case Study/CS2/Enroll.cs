using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS1;

namespace CS2
{
    class Enroll
    {
        private Student student;
        private Course course;
        private DateTime enrollDate;

        public List<Course> CourseList = new List<Course>();
        public List<Student> StudentList = new List<Student>();
        public List<Enroll> EnrollList = new List<Enroll>();

        public Enroll(Student student, Course course, DateTime enrollDate)
        {
            this.student = student;
            this.course = course;
            this.enrollDate = enrollDate;
        }

        public Student Stud { get; set; }
        public Course Cou { get; set; }
        public DateTime Enrolldate { get; set; }
    }
}
