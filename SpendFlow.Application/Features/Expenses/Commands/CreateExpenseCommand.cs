
using MediatR;
using SpendFlow.Application.DTOs;

namespace SpendFlow.Application.Features.Expenses.Commands;


public class CreateExpenseCommand : IRequest<Unit>
{
    public ExpenseDto Dto { get; }

    public CreateExpenseCommand(ExpenseDto dto)
    {
        Dto = dto;
    }
}
