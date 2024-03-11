namespace IFCE.Chaves.Domain.Entities;

public class Chave : Entity
{
    protected Chave()
    {
        
    }
    
    public Chave(long numero, Sala sala, bool isDisponivel, string color, Responsavel responsavel)
    {
        Numero = numero;
        Sala = sala;
        this.isDisponivel = isDisponivel;
        this.color = color;
        Responsavel = responsavel;
        Responsavel.AtribuirChave(this);
    }
    
    
    public long Numero { get; private set; }
    public Sala Sala { get; private set; }
    public bool isDisponivel { get; private set; }
    public string color { get; private set; } //verde ou vermelho
    
    public Responsavel Responsavel { get; set; }

    public void TorneEmUso()
    {
        isDisponivel = false;
        color = "red";
    }

    public void TorneDisponivel()
    {
        isDisponivel = true;
        color = "green";
    }
}
