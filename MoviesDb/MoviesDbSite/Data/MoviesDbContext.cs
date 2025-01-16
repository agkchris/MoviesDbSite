using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MoviesDbSite.Models;

namespace MoviesDbSite.Data;

public class MoviesDbContext : IdentityDbContext
{
    public MoviesDbContext(DbContextOptions<MoviesDbContext> options)
        : base(options)
    {
    }

    public DbSet<Movie> Movies { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Add any additional model configurations here
        builder.Entity<Movie>()
            .HasIndex(m => m.Title);
    }
}