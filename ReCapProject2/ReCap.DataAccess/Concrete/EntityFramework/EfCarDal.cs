using ReCap.Core.DataAccess.EntityFramework;
using ReCap.DataAccess.Abstract;
using ReCap.Entities.Concrete;
using ReCap.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ReCap.DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {

        public List<CarDeteailDto> GetCarsDetails()
        {
            using (ReCapContext context=new ReCapContext())
            {
                var result = from c in context.Cars
                             join cl in context.Colors
                             on c.ColorId equals cl.Id
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             select new CarDeteailDto { CarId = c.Id, CarName = c.CarName, BrandName = b.BrandName, ColorName = cl.ColorName, DailyPrice = c.DailyPrice };
                return result.ToList();
            }
        }
    }
}
