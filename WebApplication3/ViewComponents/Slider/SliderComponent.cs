using BusinessLogicLayer.Manager;
using DataAccessLayer.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace ihealth.ViewComponents.Slider
{
    public class SliderComponent:ViewComponent
    {
        SliderManager sliderManager = new SliderManager(new EfSliderRepository());
        public IViewComponentResult Invoke()
        {
            List<SliderModel> result = new List<SliderModel>();
            result = sliderManager.ListAll();
            return View(result);
        }
    }
}
