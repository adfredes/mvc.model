using MVC_Model.Models;
using System.Web.Mvc;



namespace MVC_Model.Controllers
{
	public class PersonController : Controller
	{
		
		// GET: Student/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: Student/Create
		[HttpPost]
		public ActionResult Create(Person person)
		{

            if (ModelState.IsValid)
            {

                return RedirectToAction("Create");
            }

            return View(person);
        }

        // GET: Student/Create
        public ActionResult Create2()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create2(Person person)
        {

            if (ModelState.IsValid)
            {

                return RedirectToAction("Create2");
            }

            return View(person);
        }
    }
}
