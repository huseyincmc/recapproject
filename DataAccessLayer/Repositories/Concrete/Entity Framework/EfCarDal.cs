using Core.DataAccess.EntityFramework;
using DataAccessLayer.Repositories.Abstract;
using Entities.DTOs;
using Entities.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Concrete.Entity_Framework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCarContext context = new ReCarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join k in context.Colors on c.ColorId equals k.ColorId
                             select new CarDetailDto { CarName = c.Description, BrandName = b.Name, ColorName = k.Name, DailyPrice = c.DailyPrice };

                return result.ToList();
            } 
        }
    }
}
