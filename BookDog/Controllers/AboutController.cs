using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult About()
        {
            ViewData["Title"] = "Dowiedz się więcej";
            return View();
        }
    }
}