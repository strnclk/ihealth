using Microsoft.AspNetCore.Mvc;

namespace ihealth.ViewComponents.Footer
{
    public class FooterComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
