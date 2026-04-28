using Microsoft.EntityFrameworkCore;
using Final_Project___Hope_Inman.Module;

namespace Final_Project___Hope_Inman.Data
{
    public class AppDbContext2: DbContext
    {
        public AppDbContext2(DbContextOptions<AppDbContext2> options) : base(options)
        {
        }
        public DbSet<Teams> Teams { get; set; }

    }
}