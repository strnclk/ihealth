using Microsoft.AspNetCore.Mvc;

namespace ihealth.ViewComponents.Slider
{
    public class SliderComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
