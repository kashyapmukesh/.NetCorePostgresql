using Microsoft.EntityFrameworkCore;
using login_register_postgresql.Models;

namespace login_register_postgresql.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base (options)
        {
            
        }

        public DbSet<Students> Students { get; set; }
    }
}
