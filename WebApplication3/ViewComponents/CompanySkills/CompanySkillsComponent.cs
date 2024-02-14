using Microsoft.AspNetCore.Mvc;

namespace ihealth.ViewComponents.CompanySkills
{
    public class CompanySkillsComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
