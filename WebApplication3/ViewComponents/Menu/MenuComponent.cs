using Microsoft.AspNetCore.Mvc;

namespace ihealth.ViewComponents.Menu
{
    public class MenuComponent:ViewComponent
    {
        public IViewComponentResult Invoke ()
        {
            return View();
        }
    }
}
