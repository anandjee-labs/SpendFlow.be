using MediatR;
using SpendFlow.Application.Features.Expenses.Queries;
using SpendFlow.Domain.Entities;
using SpendFlow.Domain.Interfaces;

namespace SpendFlow.Application.Features.Expenses.Handlers;

public class GetSubCategoriesHandler : IRequestHandler<GetSubCategoriesQuery, IEnumerable<ExpenseSubCategory>>
{
    private readonly IUnitOfWork _uow;

    public GetSubCategoriesHandler(IUnitOfWork uow)
    {
        _uow = uow;
    }

    public async Task<IEnumerable<ExpenseSubCategory>> Handle(GetSubCategoriesQuery request, CancellationToken cancellationToken)
    {
        return await _uow.SubCategories.GetAllAsync();
    }
}