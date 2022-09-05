using BA_Project.DAL.Context;
using BA_Project.DAL.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_Project.Validation
{
    public class AppSettingValidator : AbstractValidator<AppSetting>
    {
        public AppSettingValidator()
        {
            RuleFor(x => x.Key)
                .NotNull().WithMessage("Key can not bu null.")
                .NotEmpty().WithMessage("Key can not be empty.");

            RuleFor(x => IsUnique(x.Key)).Equal(true).WithMessage("This setting is already exist.");
        }

        public bool IsUnique(string key)
        {
            return !DB.Instance.AppSettings.Any(u => u.Key == key);
        }
    }
}
