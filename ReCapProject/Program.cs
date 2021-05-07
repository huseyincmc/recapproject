using BusinessLayer.Concrete;
using DataAccessLayer.Repositories.Concrete;
using DataAccessLayer.Repositories.Concrete.Entity_Framework;
using Entities.Entities.Concrete;
using System;

namespace ReCapProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Name);
            }
        }
    }
}
