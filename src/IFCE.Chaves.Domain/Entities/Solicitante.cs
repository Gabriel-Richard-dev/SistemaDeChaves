using System.Collections.ObjectModel;
using Microsoft.VisualBasic;

namespace IFCE.Chaves.Domain.Entities;

public class Solicitante : Pessoa
{
   protected Solicitante(){ }
    
   public Solicitante(string nome, string email, string telefone, string role) : base(nome, email, telefone, role)
   {
   }
   
}