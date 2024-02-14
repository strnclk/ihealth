using Microsoft.AspNetCore.Mvc;

namespace ihealth.ViewComponents.HomeAbout
{
    public class HomeAboutComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
