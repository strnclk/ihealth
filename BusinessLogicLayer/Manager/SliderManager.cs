using BusinessLogicLayer.Service;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Manager
{
    public class SliderManager : IGenericService<SliderModel>
    {
        private ISliderDal  slider;
        public SliderManager(ISliderDal _slider)
        {
                slider= _slider;
        }

        public void Add(SliderModel value)
        {
            throw new NotImplementedException();
        }

        public void Delete(SliderModel value)
        {
            throw new NotImplementedException();
        }

        public SliderModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<SliderModel> ListAll()
        {
            return slider.GetListAll();
        }

        public void Update(SliderModel value)
        {
            throw new NotImplementedException();
        }
    }
}
