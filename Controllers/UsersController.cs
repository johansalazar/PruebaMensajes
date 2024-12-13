using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaMensajes.Interfaces;
using PruebaMensajes.Models;
using PruebaMensajes.Repository;

namespace PruebaMensajes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ILogger<UsersController> _logger;

        public UsersController(IUserService userService, ILogger<UsersController> logger)
        {
            _userService = userService;
            _logger = logger;
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] UserRequest user)
        {
            if (string.IsNullOrWhiteSpace(user.Name) || string.IsNullOrWhiteSpace(user.PhoneNumber))
            {
                return BadRequest("El nombre y el número de teléfono son obligatorios.");
            }

            _userService.SaveUser(user);

            // Simula el envío de un mensaje.
            _logger.LogInformation("Mensaje de bienvenida enviado a {Name} al número {PhoneNumber}.", user.Name, user.PhoneNumber);

            return Ok(new { message = "Datos recibidos correctamente.", user });
        }
    }
}
