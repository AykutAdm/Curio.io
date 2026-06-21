using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curio.Modules.Users.Features.Register
{
    public class RegisterValidator : AbstractValidator<RegisterCommand>
    {
        public RegisterValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("İsim alanı boş bırakılamaz.");

            RuleFor(x => x.LastName).NotEmpty().WithMessage("Soyad alanı boş bırakılamaz.");

            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı boş bırakılamaz.").MinimumLength(3).WithMessage("Kullanıcı adı en az 3 karakter olmalı.");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş bırakılamaz.").EmailAddress().WithMessage("Geçerli bir email girin.");

            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş bırakılamaz.").MinimumLength(6).WithMessage("Şifre en az 6 karakter olmalı.");
        }
    }
}
