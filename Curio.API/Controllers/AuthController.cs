using Curio.Modules.Users.Features.Login;
using Curio.Modules.Users.Features.Register;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Curio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterCommand command)
        {
            await _mediator.Send(command);
            return Ok("Hesabınız başarıyla oluşturuldu.");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginCommand command)
        {

            var token = await _mediator.Send(command);
            return Ok(new { token });
        }
        
    }
}
