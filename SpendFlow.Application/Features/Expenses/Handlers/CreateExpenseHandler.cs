using MediatR;
using SpendFlow.Application.Features.Expenses.Commands;
using SpendFlow.Domain.Entities;
using SpendFlow.Domain.Interfaces;

namespace SpendFlow.Application.Features.Expenses.Handlers;
public class CreateExpenseHandler : IRequestHandler<CreateExpenseCommand, Unit>
{
    private readonly IUnitOfWork _uow;

    public CreateExpenseHandler(IUnitOfWork uow)
    {
        _uow = uow;
    }

    public async Task<Unit> Handle(CreateExpenseCommand request, CancellationToken ct)
    {
        var dto = request.Dto;

        if (dto.Amount <= 0)
            throw new Exception("Amount must be greater than zero");

        var expense = new Expense
        {
            Title = dto.Title,
            Amount = dto.Amount,
            CategoryId = dto.CategoryId,
            PaymentModeId = dto.PaymentModeId,
            Comments = dto.Comments,
            CreatedDate = DateTime.Now
        };

        await _uow.Expenses.AddAsync(expense);
        await _uow.CompleteAsync();

        return Unit.Value;
    }
}