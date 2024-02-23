using BusinessLogicLayer.Manager;
using DataAccessLayer.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace ihealth.ViewComponents.TopInfo
{
    public class TopInfoComponent:ViewComponent
    {
        ContactInformationManager contactInformationManager = new ContactInformationManager(new EfContactInformationRepository());
        public IViewComponentResult Invoke()
        {
            List<ContactInformationModel> result=new List<ContactInformationModel>();
            result = contactInformationManager.ListAll();
            return View(result);
        }
    }
}
