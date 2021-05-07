using Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IColorService
    {
        public List<Color> GetAll();
        public List<Color> GetByColorId(int id);
        public void Add(Color color);

    }
}
