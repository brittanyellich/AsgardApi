using AsgardApi.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace AsgardApi.Repository.Databases
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
