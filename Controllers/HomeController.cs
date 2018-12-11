using Microsoft.AspNetCore.Mvc;

namespace RazorFun.Controllers
{
    public class HomeController : Controller
    {
        // Requests
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}