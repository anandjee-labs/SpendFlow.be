using SpendFlow.Domain.Interfaces;
using SpendFlow.Infrastructure.Data;

namespace SpendFlow.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public IExpenseRepository Expenses { get; }
        public ICategoryRepository Categories { get; }
        public ISubCategoryRepository SubCategories { get; }
        public IPaymentModeRepository PaymentModes { get; }


        public UnitOfWork(
            AppDbContext context, 
            IExpenseRepository expenseRepository,
            ICategoryRepository categoriesRepository,
            ISubCategoryRepository subCategoryRepository,
            IPaymentModeRepository paymentModeRepository)
        {
            _context = context;
            Expenses = expenseRepository;
            Categories = categoriesRepository;
            SubCategories = subCategoryRepository;
            PaymentModes = paymentModeRepository;

        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}