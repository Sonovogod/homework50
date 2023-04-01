using FluentValidation.Results;
namespace HomeWork.Models;

public class ErrorViewModel
{
    public List<ValidationFailure> Request { get; set; }
}