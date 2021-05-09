using BusinessLayer.Concrete;
using Core.DataAccess;
using Core.DataAccess.EntityFramework;
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
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //CarDetailsTest(carManager);

            //GetAllTest(carManager);

            //GetCarsByBrandIdTest(carManager);



        }

        private static void GetCarsByBrandIdTest(CarManager carManager)
        {
            foreach (var car in carManager.GetCarsByBrandId(3))
            {
                Console.WriteLine(car.BrandId);
            }
        }

        private static void GetAllTest(CarManager carManager)
        {
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void CarDetailsTest(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
            }
        }
      
    }
}
