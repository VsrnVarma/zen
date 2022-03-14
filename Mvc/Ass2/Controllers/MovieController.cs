using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ass2.Models;

namespace Ass2.Controllers
{
    public class MovieController : Controller
    {
        MovieEntities me = new MovieEntities();

        // GET: Movie
        public ActionResult Index()
        {
            return RedirectToAction("GetMovietable");
        }

        public ActionResult ListByYear(Movietable mt)
        {
            return View(mt);
        }

        public ActionResult GetMovieByYear()
        {
            int year = 2018;
            List<Movietable> movie = (me.Movietables.Where(m => m.ReleaseDate.Value.Year == year ).Select(m => m)).ToList();
            return View(movie);
        }

        public ActionResult GetMovietable()
        {
            List<Movietable> mt = me.Movietables.ToList();
            return View(mt);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Movietable mt)
        {
            me.Movietables.Add(mt);
            me.SaveChanges();
            return RedirectToAction("GetMovietable");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Movietable mt = me.Movietables.Find(id);
            return View(mt);
        }
        [HttpPost]
        public ActionResult Edit(Movietable m)
        {
            Movietable mt = me.Movietables.Find(m.MovieId);
            mt.MovieName = m.MovieName;
            mt.ReleaseDate = m.ReleaseDate;
            me.SaveChanges();
            return RedirectToAction("GetMovietable");
        }


        public ActionResult Details(int id)
        {
            Movietable mt = me.Movietables.Find(id);
            return View(mt);
        }

        public ActionResult Delete(int id)
        {
            Movietable mt = me.Movietables.Find(id);
            me.Movietables.Remove(mt);
            me.SaveChanges();
            return RedirectToAction("GetMovietable");
        }
    }
}
