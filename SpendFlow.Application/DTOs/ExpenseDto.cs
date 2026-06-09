namespace SpendFlow.Application.DTOs
{
    public class ExpenseDto
    {
        public string Title { get; set; } = string.Empty;

        public decimal Amount { get; set; }

        public int CategoryId { get; set; }

        public int SubCategoryId { get; set; }

        public int PaymentModeId { get; set; }

        public string? Comments { get; set; } = string.Empty;
    }
}
