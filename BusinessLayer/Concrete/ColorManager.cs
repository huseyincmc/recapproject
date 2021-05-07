using BusinessLayer.Abstract;
using DataAccessLayer.Repositories.Abstract;
using Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class ColorManager:IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);
        }

        public List<Color> GetAll()
        {
           return _colorDal.GetAll();
        }

        public List<Color> GetByColorId(int id)
        {
            return _colorDal.GetAll(p => p.ColorId == id);
        }
    }
}
