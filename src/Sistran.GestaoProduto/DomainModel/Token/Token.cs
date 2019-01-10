using System;

namespace Sistran.GestaoProduto.DomainModel.Token
{
    public class Token
    {
        public Token(Guid id, DateTime dataExpiracao, bool valido)
        {
            this.Id = id;
            this.DataExpiracao = dataExpiracao;
            this.Valido = valido;
        }
        public Guid Id { get; private set; }
        public DateTime DataExpiracao { get; private set; }
        public bool Valido { get; private set; }
    }
}
