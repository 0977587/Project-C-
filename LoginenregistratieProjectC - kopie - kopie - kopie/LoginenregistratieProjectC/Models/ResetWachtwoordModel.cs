using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LoginenregistratieProjectC.Models
{
    public class ResetWachtwoordModel

    {
        [Display(Name ="Nieuw wachtwoord")]
        [Required(ErrorMessage ="Nieuw wachtwoord vereist",AllowEmptyStrings =false)]
        [DataType(DataType.Password)]
        public string NieuwWachtwoord { get; set; }

        [Display(Name = "Bevestig wachtwoord")]
        [DataType(DataType.Password)]
        [Compare("NieuwWachtwoord", ErrorMessage ="Nieuw wachtwoord en bevestigd wachtwoord komen niet overeen")]
        public string BevestigWachtwoord { get; set; }

        [Required]
        public string ResetCode { get; set; }

    }
}