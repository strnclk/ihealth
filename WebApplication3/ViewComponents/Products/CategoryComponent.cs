using Microsoft.AspNetCore.Mvc;

namespace ihealth.ViewComponents.Products
{
    public class CategoryComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
