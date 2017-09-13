using mvcdotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcdotnet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Deepsona()
        {
            return View();
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
        public ActionResult Showmesomething()
        {
            somethingModel stm = new somethingModel();
            stm.name = "Deepsona Das";
            stm.city = "Jalpaiguri";

            return View(stm);
        }
        public ActionResult Listpeople()
        {
            PersonModel ob = new PersonModel();
            //int i = 5 / ob.age;

            List<PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel { firstName = "Nirmalendu", lastName = "Das", age = 64, isalive = true });
            people.Add(new PersonModel { firstName = "Uma", lastName = "Das", age = 43, isalive = true });
            people.Add(new PersonModel { firstName = "Deblina", lastName = "Das", age = 31, isalive = true });
            people.Add(new PersonModel { firstName = "Deepsona", lastName = "Das", age = 26, isalive = true });
            people.Add(new PersonModel { firstName = "Jayeeta", lastName = " Das Chowdhury", age = 23, isalive = true });
            return View(people);
        }
    }
}