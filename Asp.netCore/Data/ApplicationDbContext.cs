using Asp.netCore.Models;
using Microsoft.EntityFrameworkCore;

namespace Asp.netCore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
                 
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Work> works { get; set; }
    }
}
