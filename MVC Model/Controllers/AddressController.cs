using MVC_Model.Models;
using System.Collections.Generic;
using System.Web.Mvc;



namespace MVC_Model.Controllers
{
    public class AddressController : Controller
    {

    private List<Address> list = new List<Address> ();

     
    public AddressController ()
        {

            this.list.Add (new Address() { Id = 1, Street = "Corrientes 3000", Zip = "1", Locality = "CABA", State = "Buenos Aires", Country = "Argentina"});
            this.list.Add(new Address() { Id = 12, Street = "Cordoba 3000", Zip = "12", Locality = "CABA", State = "Buenos Aires", Country = "Argentina" });
            this.list.Add(new Address() { Id = 123, Street = "Bulness 3000", Zip = "123", Locality = "CABA", State = "Buenos Aires", Country = "Argentina" });
            this.list.Add(new Address() { Id = 1234, Street = "Corrientes 3000", Zip = "1234", Locality = "CABA", State = "Buenos Aires", Country = "Argentina" });

        }



    //
    // GET: /Address/

    public ActionResult Index()
        {
            return View(this.list);
        }
                
        //
        // GET: /Address/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Address/Create

        [HttpPost]
        public ActionResult Create(Address address)
        {
            if (ModelState.IsValid)
            {
              
                return RedirectToAction("Index");
            }

            return View(address);
        }
    }
}