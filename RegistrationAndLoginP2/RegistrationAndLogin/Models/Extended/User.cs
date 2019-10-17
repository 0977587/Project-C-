using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
//namespace RegistrationAndLogin.Models.Extended
namespace RegistrationAndLogin.Models
{
    [MetadataType(typeof(UserMetadata))]
    public partial class User
    {
        public string ConfirmPassword { get; set; }
    }

    public class UserMetadata
    {

        [Display(Name = "Voornaam")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Voornaam vereist")]
        public string FirstName { get; set; }

        [Display(Name = "Achternaam")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Achternaam vereist")]
        public string LastName { get; set; }

        [Display(Name = "Emailadres")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Emailadres vereist")]
        [DataType(DataType.EmailAddress)]
        public string EmailID { get; set; }

        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Wachtwoord")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Wachtwoord vereist")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Minimaal 6 tekens vereist")]
        //[MaxLength(16, ErrorMessage = "Maximaal 16 tekens vereist")]
        public string Password { get; set; }

        [Display(Name = "Bevestig wachtwoord")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Bevestigd wachtwoord en wachtwoord komen niet overeen")]
        public string ConfirmPassword { get; set; }

    }
}