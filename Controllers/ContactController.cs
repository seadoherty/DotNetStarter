using Microsoft.AspNetCore.Mvc;
namespace StarterPages.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet("contact")]
        public IActionResult Contact()
        {
            ViewBag.Title = "Contact Me!";
            return View();
        }
    }
}