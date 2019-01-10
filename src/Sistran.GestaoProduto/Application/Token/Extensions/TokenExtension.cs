namespace Sistran.GestaoProduto.Application.Token.Extensions
{
    using DomainModel.Token;
    using Dtos;

    public static class TokenExtension
    {
        public static TokenDto ToDto(this Token token)
        {
            return new TokenDto(token.Id, token.DataExpiracao, token.Valido);
        }
    }
}
