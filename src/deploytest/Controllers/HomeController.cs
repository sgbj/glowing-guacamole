using Microsoft.AspNetCore.Mvc;

namespace deploytest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
