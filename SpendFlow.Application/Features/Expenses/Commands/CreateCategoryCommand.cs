
using MediatR;
using SpendFlow.Application.DTOs;

namespace SpendFlow.Application.Features.Expenses.Commands;


public class CreateCategoryCommand : IRequest<Unit>
{
    public CategoryDto Dto { get; }

    public CreateCategoryCommand(CategoryDto dto)
    {
        Dto = dto;
    }
}
