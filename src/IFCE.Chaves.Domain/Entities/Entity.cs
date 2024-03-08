using IFCE.Chaves.Domain.Contracts;

namespace IFCE.Chaves.Domain.Entities;

public class Entity : IEntity
{
    public Entity()
    {
        DataDeCriacao = DateTime.Now;
    }

    public long Id { get; set; }
    public DateTime DataDeCriacao { get; private set; }
    public DateTime DataDeAtualizacao { get; set; }
    
}