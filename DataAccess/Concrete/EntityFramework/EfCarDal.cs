using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal :EfEntityRespositoryBase<Car,CarCenterContext>,ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarCenterContext context=new CarCenterContext())
            {
                var result = from ca in context.Cars
                             join co in context.Colors
                             on ca.ColorId equals co.Id
                             join b in context.Brands
                             on ca.BrandId equals b.Id
                             select new CarDetailDto {CarName=ca.CarName, CarId = ca.Id, ColorName = co.ColorName, DailyPrice = ca.DailyPrice, BrandName = b.BrandName };
                return result.ToList();
            }
        }
    }
}
