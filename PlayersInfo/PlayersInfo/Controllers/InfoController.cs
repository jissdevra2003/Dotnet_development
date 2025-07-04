using Microsoft.AspNetCore.Mvc;
using PlayersInfo.Models;
namespace PlayersInfo.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Index()
        {
            var singlePlayer = new Player {
            TeamName="Real madrid",
            Name="Mbapper",
            JerseyNumber=9
            
            };

            var squad = new List<Player>
            {
                new Player {TeamName="Real madrid",Name="Arda",JerseyNumber=13},
                new Player {TeamName="Real madrid",Name="Arda",JerseyNumber=13},
                new Player {TeamName="Real madrid",Name="Arda",JerseyNumber=13}


            };


            ViewBag.One = singlePlayer;  //no need of conversion

            ViewData["Players"] = squad;
            TempData["Message"] = "Players data";
            return View();
        }
    }
}
