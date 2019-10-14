using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RazorPagesQuestions.Models;

namespace RazorPagesQuestion.Models
{
    public class Waitinglist
    {
        [Key]

        public string ID { get; set; }

        public DateTime Starttime { get; set; }
        public DateTime Enddtime { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}
