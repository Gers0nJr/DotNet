using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        public DbSet<Usuarios> Usuario { get; set; }
    }
}
