using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesQuestion.Data;
using RazorPagesQuestion.Models;

namespace RazorPagesQuestion.Pages.Waitinglists
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesQuestion.Data.RazorPagesQuestionContext _context;

        public CreateModel(RazorPagesQuestion.Data.RazorPagesQuestionContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Waitinglist Waitinglist { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Waitinglist.Add(Waitinglist);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
