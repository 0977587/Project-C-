using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LoginenregistratieProjectC.Models
{
    public class GebruikerLogin
    {


        [Display(Name ="Emailadres")]
        [Required(AllowEmptyStrings =false,ErrorMessage ="Emailadres vereist")]
        public string EmailAdres { get; set; }

        //[Display(Name ="Wachtwoord")]
        [Required(AllowEmptyStrings =false,ErrorMessage ="Wachtwoord vereist")]
        [DataType(DataType.Password)]
        //[Compare("Emailadres",ErrorMessage ="Emailadres en wachtwoord komen niet overeen")]
        public string Wachtwoord { get; set; }

        [Display(Name ="Onthoud mij")]
        public bool OnthoudMij { get; set; }
    }
}