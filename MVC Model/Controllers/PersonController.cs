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
		public ActionResult Create(Person student)
		{
			return RedirectToAction("Create");
		}

	}
}
