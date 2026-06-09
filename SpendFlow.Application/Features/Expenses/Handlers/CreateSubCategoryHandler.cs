using MediatR;
using SpendFlow.Application.Features.Expenses.Commands;
using SpendFlow.Domain.Entities;
using SpendFlow.Domain.Interfaces;

namespace SpendFlow.Application.Features.Expenses.Handlers;

public class CreateSubCategoryHandler : IRequestHandler<CreateSubCategoryCommand, Unit>
{
    private readonly IUnitOfWork _uow;

    public CreateSubCategoryHandler(IUnitOfWork uow)
    {
        _uow = uow;
    }

    public async Task<Unit> Handle(CreateSubCategoryCommand request, CancellationToken cancellationToken)
    {
        var entity = new ExpenseSubCategory
        {
            Name = request.Dto.Name,
            CategoryId = request.Dto.CategoryId
        };

        await _uow.SubCategories.AddAsync(entity);
        await _uow.CompleteAsync();

        return Unit.Value;
    }
}