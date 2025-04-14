using Microsoft.EntityFrameworkCore;

namespace practice1.Models.Movie
{
    public class MovieDbContext:DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options):base(options)
        {
            
        }
        public DbSet<Movie> Movies { get; set; }
    }
}
