
using Code_first_approch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Code_first_approch.Controllers
{
    public class HomeController : Controller
    {
        StudentsContext db = new StudentsContext();

        public ActionResult Create()
        {
            return View();  
        }
        [HttpPost]
        public ActionResult Create(Students s)
        {
            db.students.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {
            var res = db.students.ToList();
            return View(res);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}