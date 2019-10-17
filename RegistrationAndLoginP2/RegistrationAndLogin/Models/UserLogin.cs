using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrationAndLogin.Models
{
    public class UserLogin
    {
        [Display(Name = "Emailadres")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Emailadres is vereist")]
        public string EmailID { get; set; }


        [Display(Name = "Wachtwoord")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Wachtwoord is vereist")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Onthoud mij")]
        public bool RememberMe { get; set; }

    }
}