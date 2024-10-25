using BackendBiblioteca.Models;
using BackendBiblioteca.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackendBiblioteca.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetUsers")]
        public IEnumerable<User> getAllUsers(){
            return _userService.FindAllUsers();
        }
    }
}