using Sistran.SharedKernel.DomainModel;
using System;

namespace Sistran.ControleAcessos.DomainModel.Token
{
    public class Token : AggregateRoot
    {
        public Token()
        {
            this.Id = Guid.NewGuid();
            this.DataExpiracao = DateTime.Now.AddHours(1);
        }
        
        public DateTime DataExpiracao { get; private set; }

        public  bool Valido {
            get {
                return DataExpiracao > DateTime.Now;
            }
        }
    }
}
