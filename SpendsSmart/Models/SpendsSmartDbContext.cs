using Microsoft.EntityFrameworkCore;

namespace SpendsSmart.Models
{
    public class SpendsSmartDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }
        public SpendsSmartDbContext(DbContextOptions<SpendsSmartDbContext> options) : base(options)
        {
        }
    }
}
