using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Model;
using WebApp.Service;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IPersonService _personService;
        public HomeController(IPersonService personService)
        {
            _personService = personService;
        }
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Medical()
        {
            return View();
        }

        public ActionResult NetCulture()
        {
            return View();
        }


        public ActionResult Build()
        {
            return View();
        }

        public ActionResult Financing()
        {
            return View();
        }
        

        public ActionResult FoodStuff()
        {
            return View();
        }

        public ActionResult About()
        {
          

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}