namespace SpendFlow.Domain.Entities;
public class Expense
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public decimal Amount { get; set; }

    public int CategoryId  { get; set; }

    public int SubCategoryId { get; set; }

    public int PaymentModeId  { get; set; }

    public string? Comments { get; set; } = string.Empty;

    public DateTime CreatedDate { get; set; }
    
    public ExpenseCategory Category { get; set; } = null!;

    public ExpenseSubCategory SubCategory { get; set; } = null!;
    
    public PaymentMode PaymentMode { get; set; } = null!;

}
