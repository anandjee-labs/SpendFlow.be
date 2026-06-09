namespace SpendFlow.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IExpenseRepository Expenses { get; }

        ICategoryRepository Categories { get; }

        ISubCategoryRepository SubCategories { get; }
        
        IPaymentModeRepository PaymentModes { get; }

        Task<int> CompleteAsync();
    }
}