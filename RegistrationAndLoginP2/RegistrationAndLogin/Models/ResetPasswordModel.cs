using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RegistrationAndLogin.Models
{
    public class ResetPasswordModel
    {
        [Display(Name = "Nieuw wachtwoord")]
        [Required(ErrorMessage = "Nieuw wachtwoord vereist", AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [Display(Name = "Bevestig wachtwoord")]
        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage = "Nieuw wachtwoord en bevestigd wachtwoord komen niet overeen")]
        public string ConfirmPassword { get; set; }
        public string ResetCode { get; set; }
    }
}