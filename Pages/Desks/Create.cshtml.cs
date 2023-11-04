using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDesk_2._0.Data;
using MegaDesk_2._0.Models;

namespace MegaDesk_2._0.Pages.Desks
{
    public class CreateModel : PageModel
    {
        private readonly MegaDesk_2._0.Data.MegaDesk_2_0Context _context;

        public CreateModel(MegaDesk_2._0.Data.MegaDesk_2_0Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Desk Desk { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Desks == null || Desk == null)
            {
                return Page();
            }

            _context.Desks.Add(Desk);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
