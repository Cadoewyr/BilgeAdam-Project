using BA_Project.DAL.Entities;
using FluentValidation;

namespace BA_Project.Validation
{
    public class RecordValidator : AbstractValidator<Record>
    {
        public RecordValidator()
        {
            RuleFor(x => x.RecordName)
                .NotEmpty().WithMessage("Record name is required.")
                .MinimumLength(2).WithMessage("Record name length must be between 2 and 100 characters.")
                .MaximumLength(100).WithMessage("Record name length must be between 2 and 100 characters.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(2).WithMessage("Password length must be at least 2 characters.");
        }
    }
}