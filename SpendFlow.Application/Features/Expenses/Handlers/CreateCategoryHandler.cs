using MediatR;
using SpendFlow.Application.Features.Expenses.Commands;
using SpendFlow.Domain.Entities;
using SpendFlow.Domain.Interfaces;

namespace SpendFlow.Application.Features.Expenses.Handlers;

public class CreateCategoryHandler : IRequestHandler<CreateCategoryCommand, Unit>
{
    private readonly IUnitOfWork _uow;

    public CreateCategoryHandler(IUnitOfWork uow)
    {
        _uow = uow;
    }

    public async Task<Unit> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        var entity = new ExpenseCategory
        {
            Name = request.Dto.Name
        };

        await _uow.Categories.AddAsync(entity);
        await _uow.CompleteAsync();

        return Unit.Value;
    }
}