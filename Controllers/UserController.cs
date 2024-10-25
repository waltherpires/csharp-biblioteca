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

        [HttpGet]
        public IEnumerable<User> getAllUsers(){
            return _userService.FindAllUsers();
        }

        [HttpGet("/{id}")]
        public ActionResult<User> getUser(int id)
        {
            User? user = _userService.FindUserById(id);

            if(user == null)
            {
                return NotFound();
            }

            return user;
        }

        [HttpPost]
        public ActionResult<User> AddUser(User user)
        {
            return _userService.SaveUser(user);
        }

        [HttpPut]
        public ActionResult<User> UpdateUser(int id, User user)
        {
            return _userService.UpdateUser(id, user);
        }
    }
}