using Microsoft.EntityFrameworkCore;

namespace film_zad.Models
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<Kategoria> Kategoria { get; set; }

    }
}
