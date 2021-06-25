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
    [Authorize(Roles = UserRoles.Student)]
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        public StudentController()
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Welcome to StudentController");
        }
    }
}
