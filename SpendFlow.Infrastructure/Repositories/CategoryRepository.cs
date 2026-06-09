using Microsoft.EntityFrameworkCore;
using SpendFlow.Domain.Interfaces;
using SpendFlow.Infrastructure.Data;
using SpendFlow.Domain.Entities;

namespace SpendFlow.Infrastructure.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly AppDbContext _context;

    public CategoryRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<ExpenseCategory>> GetAllAsync()
    {
        return await _context.ExpenseCategory.ToListAsync();
    }

    public async Task AddAsync(ExpenseCategory category)
    {
        await _context.ExpenseCategory.AddAsync(category);
    }
}