using FluentValidation;
using FluentValidation.Internal;
using FluentValidation.Results;
using IFCE.Chaves.Domain.Entities;

namespace IFCE.Chaves.Domain.Validators;

public class PessoaValidator : AbstractValidator<Pessoa>
{
    public PessoaValidator()
    {
        RuleFor(p => p.Nome)
            .NotEmpty().WithMessage("Nome não pode estar vazio")
            .NotNull().WithMessage("Nome não pode estar nulo")
            .MaximumLength(80).WithMessage("Nome com capacidade máxima de 80 caracteres")
            .MinimumLength(3).WithMessage("Nome com capacidade mínima de 3 caracteres");
        RuleFor(p => p.Email)
            .NotEmpty().WithMessage("Email não pode estar vazio.")
            .NotNull().WithMessage("Email não pode estar nulo.")
            .Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").WithMessage("Email não está no formato correto.");
        RuleFor(p => p.Role)
            .NotEmpty().WithMessage("Role não pode estar nulo.")
            .NotNull().WithMessage("Role não pode estar vazio.");
    }
    
}    