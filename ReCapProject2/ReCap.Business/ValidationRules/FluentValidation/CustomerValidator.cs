using FluentValidation;
using ReCap.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.Business.ValidationRules.FluentValidation
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.CompanyName).NotEmpty().WithMessage("Şirket Adı Boş Geçilemez");
            RuleFor(c => c.CompanyName).MinimumLength(5).WithMessage("Şirket Adı Minimum 5 Karakter Olmalıdır");
        }
    }
}
