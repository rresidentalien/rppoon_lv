using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad7
{
    internal class RegistrationValidator : IRegistrationValidator
    {
        IEmailValidatorService emailValidator;
        IPasswordValidatorService passwordValidator;

        public RegistrationValidator()
        {
            emailValidator = new EmailValidator();
            passwordValidator = new PasswordValidator(8);
        }

        public bool IsUserEntryValid(UserEntry entry)
        {
            return emailValidator.IsValidAddress(entry.Email) && passwordValidator.IsValidPassword(entry.Password);
        }
    }
}
