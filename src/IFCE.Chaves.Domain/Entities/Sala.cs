namespace IFCE.Chaves.Domain.Entities;

public class Sala : Entity
{
    public Sala(int bloco, int numeroDaSala, bool isLaboratorio)
    {
        Bloco = bloco;
        NumeroDaSala = numeroDaSala;
        this.isLaboratorio = isLaboratorio;
    }
    
    public int Bloco { get; set; }
    public int NumeroDaSala { get; set; }
    public bool isLaboratorio { get; set; }

    
}