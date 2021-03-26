using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByBrandId(int id);
        List<Car> GetAllByDescription(string description);
        List<Car> GetAllByModelYear(string modelyear);
        List<Car> GetAllByColorId(int id);
        List<CarDetailDto> GetCarDetails();
    }
}
