using SpendFlow.Domain.Entities;

namespace SpendFlow.Domain.Interfaces;


public interface ISubCategoryRepository
{
    Task<IEnumerable<ExpenseSubCategory>> GetAllAsync();
    Task AddAsync(ExpenseSubCategory subCategory);
}