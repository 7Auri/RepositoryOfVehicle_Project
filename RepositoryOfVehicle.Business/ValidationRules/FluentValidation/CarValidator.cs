using FluentValidation;
using RepositoryOfVehicle.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryOfVehicle.Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Name).MinimumLength(2).MaximumLength(15).NotEmpty();
            RuleFor(c => c.Wheels).NotEmpty();
            
        }
    }
}
