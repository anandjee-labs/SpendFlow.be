using SpendFlow.Domain.Entities;

namespace SpendFlow.Domain.Interfaces;

public interface ICategoryRepository
{
    Task<IEnumerable<ExpenseCategory>> GetAllAsync();
    Task AddAsync(ExpenseCategory category);
}
