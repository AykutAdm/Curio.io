using Curio.Modules.Users.Domain;
using Curio.Shared.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curio.Modules.Users.Features.Login
{
    public class LoginHandler : IRequestHandler<LoginCommand, string>
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IJwtService _jwtService;

        public LoginHandler(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IJwtService jwtService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtService = jwtService;
        }

        public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null)
            {
                throw new Exception("Kullanıcı bulunamadı.");
            }
          
            var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);
            if (!result.Succeeded)
            {
                throw new Exception("Şifre hatalı.");
            }

            var token = await _jwtService.GenerateToken(user.Id, user.Email!, user.UserName!);
            return token;
        }
    }
}
