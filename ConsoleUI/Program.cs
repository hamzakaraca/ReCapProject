using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
            //CarAddingTest();


        }

        private static void CarAddingTest()
        {
            EfCarDal efCarDal = new EfCarDal();
            efCarDal.Delete(new Car { Id = 1006, BrandId = 6, ColorId = 4, DailyPrice = 25000, ModelYear = "2013", Description = "Güzel Bir Ford" });
        }

        private static void CarTest()
        {
            CarManager carmanager = new CarManager(new EfCarDal());
            foreach (var car in carmanager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + "/" +car.BrandName+ "/" + car.ColorName + "/" + car.DailyPrice);
            }
        }
    }
}
