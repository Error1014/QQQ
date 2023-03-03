using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace QQQ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public async Task<IEnumerable<User>> GetUsers()
        {
            return _userService.GetUsers();
        }
        [HttpGet(nameof(GetUser))]
        public async Task<User> GetUser(int id)
        {
            return _userService.GetById(id);
        }
        [HttpPost]
        public async Task<User> AddUser(User user)
        {
            _userService.AddUser(user);
            return user;
        }
        [HttpPut]
        public async Task<User> UpdateUser(User user)
        {
            _userService.UpdateUser(user);
            return user;
        }
        [HttpDelete]
        public async Task DeleteUser(int id)
        {
            _userService.DeleteUser(id);
        }
    }
}
