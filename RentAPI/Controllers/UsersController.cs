using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {


        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getusers")]

        public IActionResult GetUsers()
        {
            var result = _userService.GetUsers();
            if (result.Success)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("add")]

        public IActionResult Add(Users users)
        {
            var result = _userService.Add(users);
            if (result.Success)
            {
                return Ok(users);
            }
            return BadRequest(users);
        }

        [HttpGet("getbyid")]

        public IActionResult GetById(int id)
        {
            var result = _userService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }   
}
