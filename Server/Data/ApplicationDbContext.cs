using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SkyVoteTime.Server.Models;

namespace SkyVoteTime.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Vote> Votes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action" },
                new Category { Id = 2, Name = "Horror" },
                new Category { Id = 3, Name = "Drama" },
                new Category { Id = 4, Name = "Fantasy" },
                new Category { Id = 5, Name = "Comedy" },
                new Category { Id = 6, Name = "Documentary" },
                new Category { Id = 7, Name = "Thriller" },
                new Category { Id = 8, Name = "Science fiction" },
                new Category { Id = 9, Name = "Romance" }
            );
        }
    }
}