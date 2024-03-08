using System.Collections.ObjectModel;
using Microsoft.VisualBasic;

namespace IFCE.Chaves.Domain.Entities;

public class Responsavel : Pessoa
{
    public Collection<Chave> Chaves { get; set; } = new();

    protected Responsavel(){ }
    
    public Responsavel(string nome, string email, string telefone, string role) : base(nome, email, telefone, role)
    {
    }

    public void AtribuirChave(Chave chave)
    {
        Chaves.Add(chave);
    }
    
    
}