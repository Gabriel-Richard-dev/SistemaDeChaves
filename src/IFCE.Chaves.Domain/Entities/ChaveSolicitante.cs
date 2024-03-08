namespace IFCE.Chaves.Domain.Entities;

public class ChaveSolicitante
{
    public ChaveSolicitante(Chave chave, Solicitante solicitante)
    {
        Chave = chave;
        Solicitante = solicitante;
        DataDeEntrega = DateTime.Now;
        isDevolvida = false;
        Chave.TorneEmUso();
    }
    
    public Chave Chave { get; private set; }
    public Solicitante Solicitante { get; private set; }
    public DateTime DataDeEntrega { get; private set; }
    
    public bool isDevolvida { get; private set; }
    
    public DateTime DataDeDevolucao { get; private set; }

    public void Devolvida()
    {
        Chave.DataDeAtualizacao = DateTime.Now;
        Chave.TorneDisponivel();
        DataDeDevolucao = DateTime.Now;
        isDevolvida = true;
    }
    
}