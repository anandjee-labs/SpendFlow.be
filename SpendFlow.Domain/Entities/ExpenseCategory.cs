using SpendFlow.Domain.Entities;

namespace SpendFlow.Domain.Entities;
public class ExpenseCategory
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public bool IsActive { get; set; } = true;

    public ICollection<Expense> Expenses { get; set; } = new List<Expense>();

    public ICollection<ExpenseSubCategory> SubCategories { get; set; } = new List<ExpenseSubCategory>();
}