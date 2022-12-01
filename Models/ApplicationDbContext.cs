using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<TransactionViewModel> Transactions { get; set; }
        public DbSet<CategoryViewModel> Categories { get; set; }
    }
}
