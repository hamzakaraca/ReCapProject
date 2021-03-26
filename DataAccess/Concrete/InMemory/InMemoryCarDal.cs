using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=5000,ModelYear="2000",Description="Güzel bir BMW"},
                new Car{Id=2,BrandId=1,ColorId=1,DailyPrice=8000,ModelYear="2005",Description="Güzel bir AUDİ"},
                new Car{Id=3,BrandId=2,ColorId=1,DailyPrice=4000,ModelYear="1999",Description="Güzel bir NİSSAN"},
                new Car{Id=4,BrandId=3,ColorId=1,DailyPrice=20000,ModelYear="2021",Description="Güzel bir LAMBORGİNİ"},
                new Car{Id=5,BrandId=3,ColorId=1,DailyPrice=10000,ModelYear="2020",Description="Güzel bir FERRARİ"},
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c=>c.Id==car.Id);
            _car.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int ıd)
        {
            return _car.Where(c=>c.Id==ıd).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
