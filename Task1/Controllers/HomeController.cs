using Microsoft.AspNetCore.Mvc;

namespace Task1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/gt63s.jpg");
            string mimeType = "image/jpeg";
            return PhysicalFile(filePath, mimeType);
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return Ok("This is Contact page...");
        }
        public IActionResult Privacy()
        {
            return Json(new {Id=3, Name="Code Academu"});
        }
    }
}
