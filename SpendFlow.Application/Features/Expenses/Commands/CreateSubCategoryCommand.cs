
using MediatR;
using SpendFlow.Application.DTOs;

namespace SpendFlow.Application.Features.Expenses.Commands;


public class CreateSubCategoryCommand : IRequest<Unit>
{
    public SubCategoryDto Dto { get; }

    public CreateSubCategoryCommand(SubCategoryDto dto)
    {
        Dto = dto;
    }
}
