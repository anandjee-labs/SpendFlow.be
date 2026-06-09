using MediatR;
using SpendFlow.Application.Features.Expenses.Queries;
using SpendFlow.Domain.Entities;
using SpendFlow.Domain.Interfaces;

namespace SpendFlow.Application.Features.Expenses.Handlers;
public class GetExpensesHandler : IRequestHandler<GetExpensesQuery, IEnumerable<Expense>>
{
    private readonly IUnitOfWork _uow;

    public GetExpensesHandler(IUnitOfWork uow)
    {
        _uow = uow;
    }

    public async Task<IEnumerable<Expense>> Handle(GetExpensesQuery request, CancellationToken ct)
    {
        var data = await _uow.Expenses.GetAllAsync();

        // ✅ BUSINESS LOGIC HERE
        return data;
    }
}
