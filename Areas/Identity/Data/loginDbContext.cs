using film_zad.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace film_zad.Areas.Identity.Data;

public class loginDbContext : IdentityDbContext<loginUser>
{
    public loginDbContext(DbContextOptions<loginDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
    private class loginUserEntityConfiguration : IEntityTypeConfiguration<loginUser>
    {
        public void Configure(EntityTypeBuilder<loginUser> builder)
        { 
            builder.Property(x=>x.FirstName).HasMaxLength(128);
            builder.Property(x=>x.LastName).HasMaxLength(128);
        }
    }
}
