using MediatR;
using SpendFlow.Application.Features.Expenses.Queries;
using SpendFlow.Domain.Entities;
using SpendFlow.Domain.Interfaces;

namespace SpendFlow.Application.Features.Expenses.Handlers;

public class GetPaymentModeHandler : IRequestHandler<GetPaymentModesQuery, IEnumerable<PaymentMode>>
{
    private readonly IUnitOfWork _uow;

    public GetPaymentModeHandler(IUnitOfWork uow)
    {
        _uow = uow;
    }

    public async Task<IEnumerable<PaymentMode>> Handle(GetPaymentModesQuery request, CancellationToken cancellationToken)
    {
        return await _uow.PaymentModes.GetAllAsync();
    }
}