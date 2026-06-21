using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curio.Shared.Interfaces
{
    public interface IJwtService
    {
        Task<string> GenerateToken(string userId, string email, string userName);
    }
}
