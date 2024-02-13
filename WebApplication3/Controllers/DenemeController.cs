using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class DenemeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
