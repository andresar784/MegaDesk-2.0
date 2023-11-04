using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDesk_2._0.Data;
using MegaDesk_2._0.Models;

namespace MegaDesk_2._0.Pages.Desks
{
    public class DetailsModel : PageModel
    {
        private readonly MegaDesk_2._0.Data.MegaDesk_2_0Context _context;

        public DetailsModel(MegaDesk_2._0.Data.MegaDesk_2_0Context context)
        {
            _context = context;
        }

      public Desk Desk { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Desks == null)
            {
                return NotFound();
            }

            var desk = await _context.Desks.FirstOrDefaultAsync(m => m.Id == id);
            if (desk == null)
            {
                return NotFound();
            }
            else 
            {
                Desk = desk;
            }
            return Page();
        }
    }
}
