using MediatR;
using SpendFlow.Application.Features.Expenses.Commands;
using SpendFlow.Domain.Entities;
using SpendFlow.Domain.Interfaces;

namespace SpendFlow.Application.Features.Expenses.Handlers;

public class CreatePaymentModeHandler : IRequestHandler<CreatePaymentModeCommand, Unit>
{
    private readonly IUnitOfWork _uow;

    public CreatePaymentModeHandler(IUnitOfWork uow)
    {
        _uow = uow;
    }

    public async Task<Unit> Handle(CreatePaymentModeCommand request, CancellationToken cancellationToken)
    {
        var entity = new PaymentMode
        {
            Name = request.Dto.Name
        };

        await _uow.PaymentModes.AddAsync(entity);
        await _uow.CompleteAsync();

        return Unit.Value;
    }
}