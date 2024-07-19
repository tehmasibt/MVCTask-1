using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using Task1.Models;

namespace Task1.Controllers
{
    public class OtherActionController : Controller
    {
        public IActionResult Index()
        {
            List<Car> cars = new()
            {
                new(){ Id = 1, Name="Car1"},
                new(){ Id = 2, Name="Car2"},
                new(){ Id = 3, Name="Car3"},
                new(){ Id = 4, Name="Car4"},
                new(){ Id = 5, Name="Car5"},
                new(){ Id = 6, Name="Car6"}
            };
            TempData["ListOfA"] = JsonConvert.SerializeObject(cars);
            return RedirectToAction("Other", "Hostile");
            //TempData["othersend"] = cars;
            //return RedirectToAction("Other", "Hostile");
            //return View();
        }

    }
}
