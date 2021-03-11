using FluentValidation;
using ReCap.Business.Abstract;
using ReCap.Business.BusinessAspects.Autofac;
using ReCap.Business.Constants;
using ReCap.Business.ValidationRules.FluentValidation;
using ReCap.Core.Aspects.Autofac.Caching;
using ReCap.Core.Aspects.Autofac.Performance;
using ReCap.Core.Aspects.Autofac.Transaction;
using ReCap.Core.Aspects.Autofac.Validation;
using ReCap.Core.CrossCuttingConcerns.Validation.FluentValidation;
using ReCap.Core.Utilities.Results;
using ReCap.DataAccess.Abstract;
using ReCap.Entities.Concrete;
using ReCap.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.Business.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [SecuredOperation("car.add")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {            
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Car car)
        {
            Add(car);
            if (car.DailyPrice < 10)
            {
                throw new Exception("");
            }
            Add(car);
            return null;
        }

        [SecuredOperation("car.delete")]
        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        [SecuredOperation("car.list")]
        [CacheRemoveAspect("ICarService.Get")] //ICarService de ki bütün get leri siler.
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarListed);
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<Car>> GetById(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.Id == id));
        }

        public IDataResult<List<CarDeteailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDeteailDto>>(_carDal.GetCarsDetails());
        }

        [SecuredOperation("car.update")]      
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
