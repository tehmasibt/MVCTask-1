using Microsoft.AspNetCore.Mvc;
using Task1.ViewModels;
using Task1.Models;

namespace Task1.Controllers
{
    public class SendDataController : Controller
    {
        public IActionResult Send()
        {
            TempData["Name"] = "Tehmasib";
            ViewBag.Age = 20;
            ViewData["Address"] = "Baku";
            List<Car> cars = new()
            {
                new(){Id=1, Name="Mercedes"},
                new(){Id=2, Name="BMW"},
                new(){Id=3, Name="AUDI"},
                new(){Id=4, Name="Lamborghini"},
                new(){Id=5, Name="Bugatti"}
            };
            ViewData["Car"]= cars;
            return View();
        }
    }
}
