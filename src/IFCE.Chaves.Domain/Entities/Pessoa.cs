using IFCE.Chaves.Domain.Validators;

namespace IFCE.Chaves.Domain.Entities;

public abstract class Pessoa : Entity
{
    protected Pessoa() { }
    protected Pessoa(string nome, string email, string telefone, string role)
    {
        Nome = nome;
        Email = email;
        Telefone = telefone;
        Role = role;
        Validate();
    }

    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public string Role { get; private set; }


    public List<string> Validate()
    {
        var validatorHandler = new PessoaValidator();
        var result = validatorHandler.Validate(this).Errors.ToList();
        List<string> response = new();
        result.ForEach(r => response.Add(r.ErrorMessage));
        
        if (result is null)
            return null;
        
        return response;

    }

}




