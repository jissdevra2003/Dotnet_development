using Microsoft.AspNetCore.Mvc;

namespace MVCWithModels.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
