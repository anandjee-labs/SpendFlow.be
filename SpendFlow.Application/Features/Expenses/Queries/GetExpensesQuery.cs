using MediatR;
using SpendFlow.Domain.Entities;

namespace SpendFlow.Application.Features.Expenses.Queries;

public class GetExpensesQuery : IRequest<IEnumerable<Expense>>
{
}
