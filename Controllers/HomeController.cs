using Microsoft.AspNetCore.Mvc;
namespace StarterPages.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.Title = "About Me";
            ViewBag.PersonName = "Herbie Dali";
            ViewBag.Quote = "I'm an artist too";
            ViewBag.Description = "Super good description Super good description Super good descriptionSuper good description Super good descriptionSuper good descriptionSuper good descriptionSuper good description";
            return View();
        }
    }
}
