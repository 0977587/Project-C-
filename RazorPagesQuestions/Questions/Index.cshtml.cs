using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesQuestions.Data;
using RazorPagesQuestions.Models;

namespace RazorPagesQuestions.Pages.Questions
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesQuestions.Data.RazorPagesQuestionsContext _context;

        public IndexModel(RazorPagesQuestions.Data.RazorPagesQuestionsContext context)
        {
            _context = context;
        }

        public IList<Question> Question { get; set; }

        public async Task OnGetAsync()
        {
            await _context.Question.ToListAsync();
        }
    }
}
