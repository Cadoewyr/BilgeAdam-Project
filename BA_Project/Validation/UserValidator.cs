using BA_Project.DAL.Entities;
using FluentValidation;

namespace BA_Project.Validation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Username)
                .NotEmpty().WithMessage("Username is required.")
                .MinimumLength(6).WithMessage("Username length must be between 6 and 100 characters.")
                .MaximumLength(100).WithMessage("Username length must be between 6 and 100 characters.");

            RuleFor(x=>x.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(6).WithMessage("Password length must be between 6 and 100 characters.")
                .MaximumLength(100).WithMessage("Password length must be between 6 and 100 characters.");
        }
    }
}