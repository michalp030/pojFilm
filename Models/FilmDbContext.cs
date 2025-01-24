using Microsoft.EntityFrameworkCore;

namespace film_zad.Models
{
    public class FilmDbContext : DbContext
    {
        public FilmDbContext(DbContextOptions<FilmDbContext> options) : base(options)
        { 
        
        }
        public DbSet<Film> Films { get; set; }
        public DbSet<Kategoria> Kategoria { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Kategoria>().HasData(
                new Kategoria { Id = 1, Name = "Komedia" },
                new Kategoria { Id = 2, Name = "Dokument" },
                new Kategoria { Id = 3, Name = "Dramat" }
            );
            modelBuilder.Entity<Film>().HasData(
                new Film { Id = 1, Name = "Kac Vegas", Description = "Niezła impreza", Price = 50, KategoriaId = 1 },
                new Film { Id = 2, Name = "Lot 93", Description = "Chyba nie dolecą", Price = 40, KategoriaId = 2 },
                new Film { Id = 3, Name = "Furia", Description = "Wojna, strzelanie, śmierć", Price = 60, KategoriaId = 3 }
            );
        }
    }
}
