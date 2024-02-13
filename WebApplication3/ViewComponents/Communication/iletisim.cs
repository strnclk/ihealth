using Microsoft.AspNetCore.Mvc;

namespace ihealth.ViewComponents.Communication
{
    public class iletisim:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
