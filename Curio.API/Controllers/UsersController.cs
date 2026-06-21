using Curio.Modules.Users.Features.GetProfile;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Curio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("{userName}")]
        public async Task<IActionResult> GetProfile(string userName)
        {
            var query = new GetProfileQuery
            {
                UserName = userName
            };
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
