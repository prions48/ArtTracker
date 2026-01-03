using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ArtTracker.Data.Trophies
{
    public class TrophyContext : DbContext
    {
        public TrophyContext(DbContextOptions<TrophyContext> options) : base(options)
        {
            
        }
        public DbSet<Category> TrophyCategories { get; set; }
        public DbSet<Item> TrophyItems { get; set; }
        public DbSet<Effort> TrophyItemEfforts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Navigation(e => e.Items);

            modelBuilder.Entity<Item>()
                .Navigation(e => e.Efforts);
        }

    }
}