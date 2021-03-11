using ReCap.Business.Abstract;
using ReCap.Business.BusinessAspects.Autofac;
using ReCap.Business.Constants;
using ReCap.Business.ValidationRules.FluentValidation;
using ReCap.Core.Aspects.Autofac.Validation;
using ReCap.Core.Utilities.Results;
using ReCap.DataAccess.Abstract;
using ReCap.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        [SecuredOperation("rental.add")]
        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            var rentalsReturnDate = _rentalDal.GetAll(r => r.CarId == rental.CarId);
            if (rentalsReturnDate.Count>0)
            {
                foreach (var item in rentalsReturnDate)
                {
                    if (item.ReturnDate==null)
                    {
                        return new ErrorResult(Messages.RentalReturnDateIsNull);
                    }
                }
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        [SecuredOperation("customer.delete")]
        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        [SecuredOperation("customer.list")]
        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());           
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            var getById = _rentalDal.Get(r => r.Id == rentalId);
            return new SuccessDataResult<Rental>(getById);
        }

        [SecuredOperation("customer.update")]
        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
