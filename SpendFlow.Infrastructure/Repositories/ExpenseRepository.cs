using Microsoft.EntityFrameworkCore;
using SpendFlow.Domain.Interfaces;
using SpendFlow.Infrastructure.Data;
using SpendFlow.Domain.Entities;

namespace SpendFlow.Infrastructure.Repositories
{
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly AppDbContext _context;

        public ExpenseRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Expense>> GetAllAsync()
        {
            return await _context.Expenses.ToListAsync();
        }

        public async Task AddAsync(Expense expense)
        {
            await _context.Expenses.AddAsync(expense);
        }
    }
}