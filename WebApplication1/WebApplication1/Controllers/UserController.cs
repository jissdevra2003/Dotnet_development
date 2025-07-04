using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        //action methods
        public string Welcome(string message)
        {
            return message.ToUpper();
        }
        public int Add(int a,int b)
        {
            return a + b;
        }

        public IActionResult Info(string username)
        {
            //defined a variable 'Username' in ViewBag and assigned a value to 'Username' 
            ViewBag.Username = username;
            return View("Result");      //requested for (Views/User/Result.cshtml)
        }


    }
}
