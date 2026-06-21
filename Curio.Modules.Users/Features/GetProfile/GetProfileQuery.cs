using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curio.Modules.Users.Features.GetProfile
{
    public class GetProfileQuery : IRequest <GetProfileDto> 
    {
        public string UserName { get; set; }

    }
}
