using Microsoft.EntityFrameworkCore;

namespace BankTransactions.Models
{
    public class TransactionDbContext:DbContext
    {
        /*Constructor with Parameters*/
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base(options)
        {}

        /*Table for the model class*/
        public DbSet<Transaction> Transactions { get; set;}
    }
}
