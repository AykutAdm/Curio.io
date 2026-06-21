using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curio.Modules.Users.Features.Login
{
    public class LoginValidator : AbstractValidator<LoginCommand>
    {
        public LoginValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş bırakılamaz.").EmailAddress().WithMessage("Geçerli bir email adresi girin.");

            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş bırakılamaz.");
        }
    }
}
