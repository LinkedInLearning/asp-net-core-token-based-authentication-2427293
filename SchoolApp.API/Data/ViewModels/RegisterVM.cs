using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.API.Data.ViewModels
{
    public class RegisterVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
