using CarsApp.Models;
using CarsApp.ViewModel.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarsApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CarViewModel carVM = new CarViewModel();

            List<Car> cars = carVM.GetAllCars();

            return View(cars);
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