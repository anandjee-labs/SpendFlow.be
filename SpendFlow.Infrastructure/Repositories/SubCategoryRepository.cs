using Microsoft.EntityFrameworkCore;
using SpendFlow.Domain.Interfaces;
using SpendFlow.Infrastructure.Data;
using SpendFlow.Domain.Entities;

namespace SpendFlow.Infrastructure.Repositories;

public class SubCategoryRepository : ISubCategoryRepository
{
    private readonly AppDbContext _context;

    public SubCategoryRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<ExpenseSubCategory>> GetAllAsync()
    {
        return await _context.ExpenseSubCategory.ToListAsync();
    }

    public async Task AddAsync(ExpenseSubCategory subCategory)
    {
        await _context.ExpenseSubCategory.AddAsync(subCategory);
    }
}