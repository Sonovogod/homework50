using System.Text.RegularExpressions;
using FluentValidation;
using HomeWork.Models;

namespace HomeWork.Validationd;

public class CreateSeaFoodValidator : AbstractValidator<SeaFood>
{
    public CreateSeaFoodValidator()
    {
        List<string> fileType = new List<string>
        {
            ".png", ".jpeg", ".jpg"
        };
        RuleFor(food => food.Title)
            .MinimumLength(1).WithMessage("Слишком короткое название")
            .MaximumLength(20).WithMessage("Слишком длинное название")
            .NotEmpty().WithMessage("Название не должно быть пустым");
        RuleFor(food => food.Discription) 
            .MaximumLength(100)
            .WithMessage("Описание не более 100 символов")
            .MinimumLength(10)
            .WithMessage("Описание не менее 10 символов")
            .NotEmpty().WithMessage("Описание не должно быть пустым");
        RuleFor(food => food.Coast)
            .GreaterThan(0).WithMessage("Стоимость должна быть больше 0");
        RuleFor(food => food.Weight)
            .GreaterThan(0).WithMessage("Вес должен быть больше 0");
        RuleFor(food => food.ExpirationDate)
            .GreaterThan(DateTime.Now).WithMessage("Срок годности не должен быть меньше текущей даты");
        RuleFor(food => food.Image)
            .NotEmpty().WithMessage("Поле картинки не может быть пустым")
            .Must(image =>
            {
                string pattern = string.Join("|", fileType.Select(x => Regex.Escape(x)));
                if (image != null)
                {
                    if(Regex.IsMatch(image, pattern))
                        return true;
                }

                return false;
            })
            .WithMessage("Поле должно содержать ссылку на картинку в формате jpg/jpeg/png");
    }
}