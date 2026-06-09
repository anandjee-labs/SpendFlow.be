using SpendFlow.Domain.Entities;

namespace SpendFlow.Domain.Interfaces
{
    public interface IExpenseRepository
    {
        Task<IEnumerable<Expense>> GetAllAsync();
        Task AddAsync(Expense expense);
    }
}