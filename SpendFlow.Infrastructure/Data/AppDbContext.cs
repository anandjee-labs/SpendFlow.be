using Microsoft.EntityFrameworkCore;
using SpendFlow.Domain.Entities;

namespace SpendFlow.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Expense> Expenses { get; set; }
    }
}