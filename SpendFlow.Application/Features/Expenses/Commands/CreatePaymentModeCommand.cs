
using MediatR;
using SpendFlow.Application.DTOs;

namespace SpendFlow.Application.Features.Expenses.Commands;


public class CreatePaymentModeCommand : IRequest<Unit>
{
    public PaymentModeDto Dto { get; }

    public CreatePaymentModeCommand(PaymentModeDto dto)
    {
        Dto = dto;
    }
}
