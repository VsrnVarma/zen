using MvcCodeFirstEg.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MvcCodeFirstEg.Controllers
{
    public class StudentController : Controller
    {
        StudentContext sc = new StudentContext();

        // GET: Student
        public ActionResult Index()
        {
            List<Student> studList = sc.students.ToList();
            return View(studList);
        }

        public ActionResult StudentList(List<Student> stu)
        {
            return View(stu);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student s)
        {
            sc.students.Add(s);
            sc.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Student s = sc.students.Find(id);
            return View(s);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Student s = sc.students.Find(id);
            return View(s);
        }
        [HttpPost]
        public ActionResult Edit(Student st)
        {
            Student s = sc.students.Find(st.StudentId);
            s.Name = st.Name;
            s.City = st.City;
            s.Branch = st.Branch;
            s.Percentage = st.Percentage;
            sc.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Student s = sc.students.Find(id);
            sc.students.Remove(s);
            sc.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult SearchByCity()
        {
            return View();
        }
        
        public ActionResult StudCity(string city)
        {
            return View(sc.students.Where(s => s.City == city).ToList());
        }


        public ActionResult SearchByBranch()
        {
            return View();
        }
        public ActionResult StudBranch(string branch)
        {
            return View(sc.students.Where(s => s.Branch == branch).ToList());
        }

        public ActionResult SearchByPercent()
        {
            return View();
        }
        public ActionResult StudPercent(int start,int end)
        {
            List<Student> pList = (from s in sc.students
                                   where s.Percentage >= start && s.Percentage <= end
                                   select s).ToList();
            return View(pList);
        }
    }
}