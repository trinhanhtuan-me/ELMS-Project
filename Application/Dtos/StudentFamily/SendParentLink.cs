using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.StudentFamily
{
    public record SendParentLinkRequest(string ParentEmail);


    public class SendParentLinkRequestValidator : AbstractValidator<SendParentLinkRequest>
    {
        public SendParentLinkRequestValidator()
        {
            RuleFor(x => x.ParentEmail)
                .NotEmpty().WithMessage("Email is required")
                .EmailAddress().WithMessage("Entered email is not a valid email");
        }
    }

}
