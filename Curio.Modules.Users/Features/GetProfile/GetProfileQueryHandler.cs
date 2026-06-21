using AutoMapper;
using Curio.Modules.Users.Domain;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curio.Modules.Users.Features.GetProfile
{
    public class GetProfileQueryHandler : IRequestHandler<GetProfileQuery, GetProfileDto>
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public GetProfileQueryHandler(UserManager<AppUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<GetProfileDto> Handle(GetProfileQuery request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);
            if (user == null)
            {
                throw new Exception("Kullanıcı bulunamadı.");
            }

            return _mapper.Map<GetProfileDto>(user);
        }
    }
}
