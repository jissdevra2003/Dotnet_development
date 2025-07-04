using Microsoft.AspNetCore.Mvc;

namespace Views_practice.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Welcome(string name)
        {
            name = "Pheonix";
            Console.WriteLine("Welcome got called");
            //using TempData we can pass data across different actions methods and views 
            TempData["Name"] = name;
            ViewData["Name1"] = $"{name}1";
            return RedirectToAction("Index");   //called Index action method
        }
        public IActionResult Index()
        {
            
            Console.WriteLine("Index got called");
            return View();
        }
    }
}
