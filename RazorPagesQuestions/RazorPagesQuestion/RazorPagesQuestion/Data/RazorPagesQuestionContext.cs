using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesQuestions.Models;

namespace RazorPagesQuestion.Data
{
    public class RazorPagesQuestionContext : DbContext
    {
        public RazorPagesQuestionContext (DbContextOptions<RazorPagesQuestionContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesQuestions.Models.Question> Question { get; set; }
    }
}
