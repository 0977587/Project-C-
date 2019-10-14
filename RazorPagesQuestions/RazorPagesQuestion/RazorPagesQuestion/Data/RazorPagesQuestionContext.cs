﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesQuestions.Models;
using RazorPagesQuestion.Models;

namespace RazorPagesQuestion.Data
{
    public class RazorPagesQuestionContext : DbContext
    {
        public RazorPagesQuestionContext (DbContextOptions<RazorPagesQuestionContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesQuestions.Models.Question> Question { get; set; }

        public DbSet<RazorPagesQuestion.Models.Waitinglist> Waitinglist { get; set; }
            
    
    }
}