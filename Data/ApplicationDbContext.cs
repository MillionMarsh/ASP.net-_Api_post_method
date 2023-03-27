using apipractice.Models;
using Microsoft.EntityFrameworkCore;

namespace apipractice.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 

        }

        public DbSet<Country> countries { get; set; }

    }
}
