using Microsoft.AspNetCore.Mvc;
using SpendFlow.Application.DTOs;
using MediatR;
using SpendFlow.Application.Features.Expenses.Queries;
using SpendFlow.Application.Features.Expenses.Commands;

namespace SpendFlow.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PaymentModeController : ControllerBase
{
    private readonly IMediator _mediator;

    public PaymentModeController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var data = await _mediator.Send(new GetPaymentModesQuery());
        return Ok(data);
    }

    [HttpPost]
    public async Task<IActionResult> Create(PaymentModeDto dto)
    {
        await _mediator.Send(new CreatePaymentModeCommand(dto));
        return Ok();
    }
}