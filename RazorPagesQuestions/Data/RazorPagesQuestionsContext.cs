using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesQuestions.Models;

namespace RazorPagesQuestions.Data
{
    public class RazorPagesQuestionsContext : DbContext
    {
        public RazorPagesQuestionsContext (DbContextOptions<RazorPagesQuestionsContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesQuestions.Models.Question> Question { get; set; }
    }
}
