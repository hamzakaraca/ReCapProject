using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetAllByColorId(int colorid)
        {
            return _carDal.GetAll(c => c.ColorId ==colorid);
        }

        public List<Car> GetAllByDescription(string description)
        {
            return _carDal.GetAll(c => c.Description == description);
        }

        public List<Car> GetAllByModelYear(string modelyear)
        {
            return _carDal.GetAll(c => c.ModelYear == modelyear);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
