using MediatR;
using SpendFlow.Domain.Entities;

namespace SpendFlow.Application.Features.Expenses.Queries;

public record GetCategoriesQuery() : IRequest<IEnumerable<ExpenseCategory>>;