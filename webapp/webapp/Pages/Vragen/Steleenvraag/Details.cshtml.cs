using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using webapp.Data;
using webapp.Models;

namespace webapp.Pages.Vragen.Steleenvraag
{
    public class DetailsModel : PageModel
    {
        private readonly webapp.Data.webappContext _context;

        public DetailsModel(webapp.Data.webappContext context)
        {
            _context = context;
        }

        public Vraag Vraag { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Vraag = await _context.Vraag.FirstOrDefaultAsync(m => m.VraagID == id);

            if (Vraag == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
