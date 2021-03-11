using FluentValidation;
using ReCap.Core.Entities.Concrete;
using ReCap.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty().WithMessage("Isim boş geçilemez");
            RuleFor(u => u.LastName).NotEmpty().WithMessage("Soyisim boş geçilemez");
            RuleFor(u => u.Email).EmailAddress().WithMessage("Email adresi boş geçilemez");
            
        }
    }
}
