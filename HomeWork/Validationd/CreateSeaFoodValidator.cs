using FluentValidation;
using HomeWork.Models;

namespace HomeWork.Validationd;

public class CreateSeaFoodValidator : AbstractValidator<SeaFood>
{
    public CreateSeaFoodValidator()
    {
        RuleFor(food => food.Title)
            .MinimumLength(1).WithMessage("Слишком короткое название")
            .MaximumLength(20).WithMessage("Слишком длинное название");
        RuleFor(food => food.Discription) 
            .MaximumLength(100)
            .WithMessage("Не более 100 символов")
            .MinimumLength(10)
            .WithMessage("Не менее 10 символов");
        RuleFor(food => food.Coast)
            .GreaterThan(0).WithMessage("Стоимость должна быть больше 0");
        RuleFor(food => food.Weight)
            .GreaterThan(0).WithMessage("Вес должен быть больше 0");
        RuleFor(food => food.ExpirationDate)
            .GreaterThan(DateTime.Now).WithMessage("Срок годности не должен быть меньше текущей даты");
    }
}