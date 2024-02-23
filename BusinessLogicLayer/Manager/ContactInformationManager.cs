using BusinessLogicLayer.Service;
using DataAccessLayer.Astract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Manager
{
    public class ContactInformationManager : IGenericService<ContactInformationModel>
    {
        private IContactInformationDal contactInformatıon;
        public ContactInformationManager(IContactInformationDal _contactInformation)
        {
            contactInformatıon = _contactInformation;
        }

        public void Add(ContactInformationModel value)
        {
            throw new NotImplementedException();
        }

        public void Delete(ContactInformationModel value)
        {
            throw new NotImplementedException();
        }

        public ContactInformationModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactInformationModel> ListAll()
        {
            return contactInformatıon.GetListAll();
        }

        public void Update(ContactInformationModel value)
        {
            throw new NotImplementedException();
        }
    }
}
