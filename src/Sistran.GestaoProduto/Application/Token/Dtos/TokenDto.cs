using System;

namespace Sistran.GestaoProduto.Application.Token.Dtos
{
    public class TokenDto
    {
        public TokenDto(Guid id, DateTime dataExpiracao, bool valido)
        {
            this.Id = id;
            this.DataExpiracao = dataExpiracao;
            this.Valido = valido;
        }
        public Guid Id { get; private set; }
        public DateTime DataExpiracao { get; private set; }
        public bool Valido { get; set; }
    }
}
