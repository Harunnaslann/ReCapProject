using FluentValidation;
using ReCap.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.Business.ValidationRules.FluentValidation
{
    public class RentalValidator:AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.RentDate).NotEmpty().WithMessage("Kiralama tarihi boş olamaz");
            RuleFor(r => r.ReturnDate).NotEmpty().WithMessage("Aracın kiradan dönüş tarihi boş olamaz");
        }
    }
}
