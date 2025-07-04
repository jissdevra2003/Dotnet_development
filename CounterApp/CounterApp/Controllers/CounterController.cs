using Microsoft.AspNetCore.Mvc;

namespace CounterApp.Controllers
{
    public class CounterController : Controller
    {
        private static int _count = 0;

        //get request
        // Handles GET requests to /Counter/Index
        // Returns the current count to the view
        public IActionResult Index()
        {
            
            
            return View(_count);  //passed value of _count to View ---> View(9)

            //string name = "Jiss";
            //return View("Index", name);    //tell MVC to render the Index view and pass the variable `message` as the model for that view

        }


        // Handles POST requests to /Counter/Increment
        // Increments the static count and redirects to Index to show updated value
        [HttpPost]
        public IActionResult Increment()
        {
            _count++;
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Decrement()
        {
            _count--;
            return RedirectToAction(nameof(Index));
        }
    }
}
