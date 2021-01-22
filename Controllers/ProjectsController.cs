using Microsoft.AspNetCore.Mvc;
namespace StarterPages.Controllers
{
    public class ProjectsController : Controller
    {
        [HttpGet("projects")]
        public IActionResult Project()
        {
            ViewBag.Title = "Here are some projects of mine!";
            return View();
        }
    }
}
