using MediatR;
using SpendFlow.Application.Features.Expenses.Queries;
using SpendFlow.Domain.Entities;
using SpendFlow.Domain.Interfaces;

namespace SpendFlow.Application.Features.Expenses.Handlers;

public class GetCategoriesHandler : IRequestHandler<GetCategoriesQuery, IEnumerable<ExpenseCategory>>
{
    private readonly IUnitOfWork _uow;

    public GetCategoriesHandler(IUnitOfWork uow)
    {
        _uow = uow;
    }

    public async Task<IEnumerable<ExpenseCategory>> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
    {
        return await _uow.Categories.GetAllAsync();
    }
}