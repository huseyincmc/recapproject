using Core.DataAccess.EntityFramework;
using DataAccessLayer.Repositories.Abstract;
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
    public class EfColorDal : EfEntityRepositoryBase<Color, ReCarContext>, IColorDal
    {
       
    }
}
