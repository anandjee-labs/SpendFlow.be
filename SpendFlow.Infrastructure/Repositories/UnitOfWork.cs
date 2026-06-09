using SpendFlow.Domain.Interfaces;
using SpendFlow.Infrastructure.Data;

namespace SpendFlow.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public IExpenseRepository Expenses { get; }

        public UnitOfWork(AppDbContext context, IExpenseRepository expenseRepository)
        {
            _context = context;
            Expenses = expenseRepository;
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}