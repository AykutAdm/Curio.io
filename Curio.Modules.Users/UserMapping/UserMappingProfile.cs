using AutoMapper;
using Curio.Modules.Users.Domain;
using Curio.Modules.Users.Features.GetProfile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curio.Modules.Users.UserMapping
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<AppUser, GetProfileDto>();
        }
    }
}
