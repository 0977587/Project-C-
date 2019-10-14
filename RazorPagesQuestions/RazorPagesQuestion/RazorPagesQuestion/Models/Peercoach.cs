using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RazorPagesQuestions.Models;

namespace RazorPagesQuestion.Models
{
    public class Peercoach
    { 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Name { get; set; }
        DateTime Starttime { get; set; }
        DateTime EndTime { get; set; }

    }
}
