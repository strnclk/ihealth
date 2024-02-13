using Microsoft.AspNetCore.Mvc;

namespace ihealth.ViewComponents.TopInfo
{
    public class TopInfoComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
