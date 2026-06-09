using Microsoft.AspNetCore.Mvc;
using SpendFlow.Application.DTOs;
using MediatR;
using SpendFlow.Application.Features.Expenses.Queries;
using SpendFlow.Application.Features.Expenses.Commands;

namespace SpendFlow.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpenseController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ExpenseController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet("health")]
        public IActionResult Health()
        {
            return Ok(new
            {
                status = "Healthy",
                service = "SpendFlow API",
                timestamp = DateTime.UtcNow
            });
        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _mediator.Send(new GetExpensesQuery());
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ExpenseDto dto)
        {
            await _mediator.Send(new CreateExpenseCommand(dto));
            return Ok();
        }

    }
}