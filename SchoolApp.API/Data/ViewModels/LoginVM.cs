using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.API.Data.ViewModels
{
    public class LoginVM
    {
        [Required]
        public string EmailAddress { get; set; }
        
        [Required]
        public string Password { get; set; }
    }
}
