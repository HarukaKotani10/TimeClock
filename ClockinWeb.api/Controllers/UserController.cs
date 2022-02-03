using AutoMapper;
using TimeClockLibrary;
using TimeClock.api.Data;
using TimeClock.api.Properties.Models;
using Microsoft.AspNetCore.Mvc;

namespace TimeClock.api.Controllers
{
    //api/user
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _repository;
        public UserController(IUserRepo repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAllUsers()
        {
            var users = _repository.GetAppUsers();
            return Ok(users);
        }

        //GET api/user/1
        [HttpGet("{id}")]
        public ActionResult <User> GetUserById(int id)
        {
            var user = _repository.GetUserById(id);
            if(user != null)
                return Ok(user);

            return NotFound();
        }

        [HttpPost]
        public ActionResult<User> CreateUser()
        {
            var user = new User() { FirstName="ksdfjslkd", LastName="sdfsdf", Passcode=1234, BranchID=1};
            _repository.CreateUser(user);
            _repository.SaveChanges();
            return Ok(user);
        }
    }
}
