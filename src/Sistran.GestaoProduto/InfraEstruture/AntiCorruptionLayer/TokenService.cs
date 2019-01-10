using Sistran.GestaoProduto.TokenServiceReference;

namespace Sistran.GestaoProduto.InfraEstruture.AntiCorruptionLayer
{
    using System;
    using DomainModel.Token;
    public class TokenService
    {
        private TokenServiceClient _tokenServiceClient; 
        public TokenService()
        {
            _tokenServiceClient = new TokenServiceClient("BasicHttpBinding_ITokenService");
        }

        public Token Create()
        {
            var result = _tokenServiceClient.GenerateToken();
            return new Token(result.Id, result.DataExpiracao, result.Valido);
        }

        public bool Validate(Guid idToken)
        {
            var resul = _tokenServiceClient.ValidateToken(idToken);
            return resul;
        }
    }
}
