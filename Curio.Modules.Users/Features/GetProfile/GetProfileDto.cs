using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curio.Modules.Users.Features.GetProfile
{
    public class GetProfileDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string? Bio { get; set; }
        public string? AvatarUrl { get; set; }
        public bool IsPrivate { get; set; }
        public int FollowerCount { get; set; }
        public int FollowingCount { get; set; }
    }
}
