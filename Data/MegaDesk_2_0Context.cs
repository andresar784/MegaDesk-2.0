using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MegaDesk_2._0.Models;

namespace MegaDesk_2._0.Data
{
    public class MegaDesk_2_0Context : DbContext
    {
        public MegaDesk_2_0Context (DbContextOptions<MegaDesk_2_0Context> options)
            : base(options)
        {
        }

        public DbSet<MegaDesk_2._0.Models.Desk> Desks { get; set; } = default!;
    }
}
