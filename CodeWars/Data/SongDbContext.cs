using Microsoft.EntityFrameworkCore;
using CodeWars.Models;

namespace CodeWars.Data
{
    public class SongDbContext : DbContext
    {
        public DbSet<Song>? Songs { get; set; }
        public SongDbContext(DbContextOptions<SongDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Song>().HasData(
            new
            {
                SongId = Guid.NewGuid().ToString(),
                Title = "Thriller",
                Artist = "Michael Jackson",
                Year = "1982"
            }, new
            {
                SongId = Guid.NewGuid().ToString(),
                Title = "Shower",
                Artist = "James Taylor",
                Year = "1976"
            }
            );
        }


    }
}
