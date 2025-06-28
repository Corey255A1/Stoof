using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Stoof.Models
{

    public class StoofContext : DbContext
    {
        public StoofContext(DbContextOptions<StoofContext> options)
            : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
    }
}
