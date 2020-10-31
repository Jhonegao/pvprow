using Microsoft.AspNetCore.Mvc;
using PVApi.Data;
using PVApi.Models;
using System.Collections.Generic;

namespace PVApi.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepo _repository;

        public UsersController(IUserRepo repository)
        {
            _repository = repository;
        }
        //private readonly MockUserRepo _repository = new MockUserRepo();
        [HttpGet]
        public ActionResult <IEnumerable<User>> GetAllUsers()
        {
            var userItems = _repository.GetAllUsers();

            return Ok(userItems);
        }

        [HttpGet("{id}")]
        public ActionResult <User> GetUserById(int id)
        {
            var userItem = _repository.GetUserByID(id);
            return Ok(userItem);
        }
    }
}
