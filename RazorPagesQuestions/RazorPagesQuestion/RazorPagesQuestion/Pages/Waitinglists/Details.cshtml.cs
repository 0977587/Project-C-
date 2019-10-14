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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesQuestion.Data.RazorPagesQuestionContext _context;

        public DetailsModel(RazorPagesQuestion.Data.RazorPagesQuestionContext context)
        {
            _context = context;
        }

        public Waitinglist Waitinglist { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Waitinglist = await _context.Waitinglist.FirstOrDefaultAsync(m => m.ID == id);

            if (Waitinglist == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
