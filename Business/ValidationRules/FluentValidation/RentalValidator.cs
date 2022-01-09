using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(rental => rental.CustomerId).NotEmpty();
            RuleFor(rental => rental.CarId).NotEmpty();
            RuleFor(rental => rental.RentDate).NotEmpty();
        }

    }
}
