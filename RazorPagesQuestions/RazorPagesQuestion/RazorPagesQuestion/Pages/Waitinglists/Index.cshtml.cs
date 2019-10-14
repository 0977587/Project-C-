using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesQuestion.Data;
using RazorPagesQuestion.Models;

namespace RazorPagesQuestion.Pages.Waitinglists
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesQuestion.Data.RazorPagesQuestionContext _context;

        public IndexModel(RazorPagesQuestion.Data.RazorPagesQuestionContext context)
        {
            _context = context;
        }

        public IList<Waitinglist> Waitinglist { get;set; }

        public async Task OnGetAsync()
        {
            Waitinglist = await _context.Waitinglist.ToListAsync();
        }
    }
}
