using Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IBrandService
    {
        public List<Brand> GetAll();
        public List<Brand> GetByBrandId(int id);
        public void Add(Brand brand);

    }
}
