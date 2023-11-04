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
    public class IndexModel : PageModel
    {
        private readonly MegaDesk_2._0.Data.MegaDesk_2_0Context _context;

        public IndexModel(MegaDesk_2._0.Data.MegaDesk_2_0Context context)
        {
            _context = context;
        }

        public IList<Desk> Desk { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Desks != null)
            {
                Desk = await _context.Desks.ToListAsync();
            }
        }
    }
}
