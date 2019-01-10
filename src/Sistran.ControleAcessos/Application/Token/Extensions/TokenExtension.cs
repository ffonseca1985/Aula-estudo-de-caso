using Sistran.ControleAcessos.Application.Token.Dto;

namespace Sistran.ControleAcessos.Application.Token.Extensions
{
    using DomainModel.Token;
    public static class TokenExtension
    {
        public static TokenDto ToDto(this Token token)
        {
            return new TokenDto(token.Id, token.DataExpiracao, token.Valido);
        }
    }
}
