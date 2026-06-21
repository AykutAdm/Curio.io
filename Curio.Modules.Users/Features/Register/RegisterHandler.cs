using Curio.Modules.Users.Domain;
using Curio.Shared.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curio.Modules.Users.Features.Register
{
    public class RegisterHandler : IRequestHandler<RegisterCommand>
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterHandler(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            var existingUser = await _userManager.FindByEmailAsync(request.Email);
            if (existingUser != null)
            {
                throw new Exception("Bu email zaten kayıtlı.");
            }

            var user = new AppUser
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                UserName = request.UserName,
                Email = request.Email,
                CreatedAt = DateTime.Now
            };

            var result = await _userManager.CreateAsync(user, request.Password);
        }
    }
}
