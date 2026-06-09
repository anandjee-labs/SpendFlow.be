using SpendFlow.Domain.Entities;

namespace SpendFlow.Domain.Entities;
public class ExpenseSubCategory
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public int CategoryId { get; set; }

    public bool IsActive { get; set; } = true;

    public ExpenseCategory Category { get; set; } = null!;

    public ICollection<Expense> Expenses { get; set; } = new List<Expense>();
}
