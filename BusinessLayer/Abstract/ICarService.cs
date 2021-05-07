using Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface ICarService
    {
        List<Car> GetAll();
        public List<Car> GetCarsByBrandId(int id);
        public List<Car> GetCarsByColorId(int id);
        public void Add(Car car);


    }
}
