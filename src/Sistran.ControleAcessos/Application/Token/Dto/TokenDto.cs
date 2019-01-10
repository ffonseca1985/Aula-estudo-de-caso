using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistran.ControleAcessos.Application.Token.Dto
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
        public bool Valido { get; private set; }
    }
}
