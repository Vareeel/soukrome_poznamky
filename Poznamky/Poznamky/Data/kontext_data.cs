using Microsoft.EntityFrameworkCore;

namespace Poznamky.Data
{
    public class kontext_data  : DbContext
    {
        public DbSet<Models.poznamka> Novinky { get; set; }
        public DbSet<Models.pripojeni> Pristup { get; set; }

        public kontext_data (DbContextOptions<kontext_data> options) : base(options) { }
    }
}