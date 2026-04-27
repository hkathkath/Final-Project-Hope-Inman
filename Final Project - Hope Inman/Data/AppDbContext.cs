using Microsoft.EntityFrameworkCore;
using Final_Project___Hope_Inman.Module;

namespace Final_Project___Hope_Inman.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        }
        public DbSet<Student> Students { get; set; }

    }
}
