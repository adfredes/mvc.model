using MVC_Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Model.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }

        public ActionResult ViewRawModel ()
        {
                        
            ViewBag.Message  = "Showing model data raw";
            ViewBag.Message2 = "Student Model";

            Student s = new Student ();

            s.ID = 123;
            s.FirstName  = "Homer";
            s.MiddleName = "J.";
            s.LastName   = "Simpson";
            s.Email = "hsimpson@gmail.com";
            s.Birthday = DateTime.Now;

            return View (s);
        }

        public ActionResult ViewDisplayModel()
        {

            ViewBag.Message = "Showing model data using display";
            ViewBag.Message2 = "Teacher Model";

            Teacher t = new Teacher();

            t.ID = 123;
            t.FirstName = "W.";
            t.MiddleName = "Seymour";
            t.LastName = "Skinner";
            t.Email = "wskinner@gmail.com";
            t.Birthday = DateTime.Now;

            return View(t);
        }

        public ActionResult ViewFormatModel()
        {

            ViewBag.Message = "Showing model data using format";
            ViewBag.Message2 = "Employee Model";

            Employee e = new Employee();

            e.ID = 123;
            e.FirstName = "Edna";
            e.MiddleName = "";
            e.LastName = "Krabappel";
            e.Email = "ekrabappel@gmail.com";
            e.Birthday = DateTime.Now;

            return View(e);
        }

        public ActionResult ViewResourceModel()
        {

            ViewBag.Message = "Showing model data using format";
            ViewBag.Message2 = "Director Model";

            Director d = new Director();

            d.ID = 123;
            d.FirstName = "Bart";
            d.MiddleName = "";
            d.LastName = "Simpson";
            d.Email = "bart.simpson@gmail.com";
            d.Birthday = DateTime.Now;

            return View(d);
        }
    }
}