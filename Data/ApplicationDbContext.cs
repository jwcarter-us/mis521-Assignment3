using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using mis521_Assignment3.Models;

namespace mis521_Assignment3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<mis521_Assignment3.Models.Actor> Actor { get; set; }
        public DbSet<mis521_Assignment3.Models.Movie> Movie { get; set; }
        public DbSet<mis521_Assignment3.Models.MovieActor> MovieActor { get; set; }
    }
}