using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Task1.Models;
using Task1.ViewModels;

namespace Task1.Controllers
{
    public class HostileController : Controller
    {
        public IActionResult Index()
        {
            List<Car> cars = new()
            {
                new(){Id=1, Name="E63s"},
                new(){Id=2, Name="C63s"},
                new(){Id=3, Name="GT63s"},
            };
            HostileVM vm = new();
            vm.Id = 8;
            vm.Car = cars[2];
            vm.Cars = cars;
            return View(vm);
            //TempData["Cars"] = JsonConvert.SerializeObject(cars);
            //return RedirectToAction("Other");
        }
        public IActionResult Other()
        {
            var listJson = TempData["ListOfA"] as string; // JSON stringini aliriq.
            var list = JsonConvert.DeserializeObject<List<Car>>(listJson); // JSON stringini list-e ceviririk.
            return View(list);
            //return View();
        }
    }
}