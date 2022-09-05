using BA_Project.DAL.Context;
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

            RuleFor(x => IsUnique(x.Username)).Equal(true).WithMessage("This username already used.");

            RuleFor(x=>x.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(6).WithMessage("Password length must be between 6 and 100 characters.")
                .MaximumLength(100).WithMessage("Password length must be between 6 and 100 characters.");

            RuleFor(x => x.EMail)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Please use a valid email address.");
        }

        public bool IsUnique(string username)
        {
            return !DB.Instance.Users.Any(u => u.Username == username);
        }
    }
}