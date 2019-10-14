using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesQuestion.Data;
using RazorPagesQuestion.Models;

namespace RazorPagesQuestion.Pages.Waitinglists
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesQuestion.Data.RazorPagesQuestionContext _context;

        public EditModel(RazorPagesQuestion.Data.RazorPagesQuestionContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Waitinglist).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WaitinglistExists(Waitinglist.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool WaitinglistExists(string id)
        {
            return _context.Waitinglist.Any(e => e.ID == id);
        }
    }
}
