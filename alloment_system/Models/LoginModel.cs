using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace alloment_system.Models
{
    public class LoginModel
    {
        [required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }
        [required(ErrorMessage = "Password Is Requiured")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}