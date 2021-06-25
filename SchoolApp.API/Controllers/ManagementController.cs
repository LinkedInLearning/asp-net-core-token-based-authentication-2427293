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
    [Authorize(Roles = UserRoles.Manager)]
    [ApiController]
    [Route("[controller]")]
    public class ManagementController : ControllerBase
    {
        public ManagementController()
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Welcome to ManagementController");
        }
    }
}
