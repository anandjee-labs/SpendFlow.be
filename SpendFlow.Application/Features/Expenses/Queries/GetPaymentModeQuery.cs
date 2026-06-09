using MediatR;
using SpendFlow.Domain.Entities;

namespace SpendFlow.Application.Features.Expenses.Queries;

public record GetPaymentModesQuery() : IRequest<IEnumerable<PaymentMode>>;