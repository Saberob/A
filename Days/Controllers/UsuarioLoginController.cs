using Days.Models;
using Days.Models.Request;
using Days.Models.Response;
using Days.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Days.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioLoginController : ControllerBase
    {
        private IUserService _userService;

        public UsuarioLoginController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public IActionResult Autentify([FromBody] AuthRequest model)
        {
            Response response = new Response();

            var userResponse = _userService.Auth(model);

            if(userResponse == null)
            {
                response.Exito = 0;
                response.Mensaje = "Usuario o contraseña Incorrecto";
                return BadRequest(response);
            }

            response.Exito = 1;
            response.Data = userResponse;
            return Ok(model);
        }
    }
}
