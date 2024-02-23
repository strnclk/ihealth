using Microsoft.AspNetCore.Mvc;

namespace ihealth.Controllers
{
    public class urun : Controller
    {
        public IActionResult sambucol(string productName)
        {
            return View();
        }
        public IActionResult pro_probiotic()
        {
            return View();
        }
        public IActionResult haliborange()
        {
            return View();
        }
    }
}
