using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDesk_2._0.Data;
using MegaDesk_2._0.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using static System.Reflection.Metadata.BlobBuilder;

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

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        
        public string DateSort { get; set; }
        public string NameSort { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {
            var desks = from d in _context.Desks select d;

            DateSort = String.IsNullOrEmpty(sortOrder) ? "date_desc" : "";
            NameSort = sortOrder == "Name" ? "name_desc" : "Name";

            switch (sortOrder)
            {
                case "date_desc":
                    desks = desks.OrderByDescending(s => s.date); break;
                case "Name":
                    desks = desks.OrderBy(s => s.name); break;
                case "name_desc":
                    desks = desks.OrderByDescending(s => s.name); break;
                default:
                    desks = desks.OrderBy(s => s.date); break;
            }


            if (!string.IsNullOrEmpty(SearchString))
            {
                desks = desks.Where(s => s.name.Contains(SearchString));
            }



            Desk = await desks.ToListAsync();
        }
    }
}
