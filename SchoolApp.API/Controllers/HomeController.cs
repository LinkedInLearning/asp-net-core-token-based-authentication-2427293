using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchoolApp.API.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        public HomeController()
        {
        }

        [HttpGet("student")]
        [Authorize(Roles = UserRoles.Student)]
        public IActionResult GetStudent()
        {
            return Ok("Welcome to HomeController - Student");
        }

        [HttpGet("manager")]
        [Authorize(Roles = UserRoles.Manager)]
        public IActionResult GetManager()
        {
            return Ok("Welcome to HomeController - Manager");
        }
    }
}
