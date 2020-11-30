using Microsoft.EntityFrameworkCore;
using PlaygroundReview.Domain;
using PlaygroundReview.Models;
using PlaygroundReview.WebApp.Helpers;

namespace PlaygroundReview.WebApp.Context
{
    public class PlaygroundsContext:DbContext
    {
        public DbSet<Playground> Playgrounds { get; set; }
        public DbSet<User> Users { get; set; }

        public PlaygroundsContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(Secrets.DatabaseConnectionString);
        }
    }
}
