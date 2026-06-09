namespace SpendFlow.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IExpenseRepository Expenses { get; }
        Task<int> CompleteAsync();
    }
}