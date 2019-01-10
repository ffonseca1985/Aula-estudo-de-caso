using System;
using APL = Sistran.ControleAcessos.Application.Token;

namespace Sistran.ControleAcessosService
{
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class TokenService : ITokenService
    {
        APL.TokenService _tokenService;

        public TokenService(APL.TokenService tokenService)
        {
            _tokenService = tokenService;
        }

        public Token GenerateToken()
        {
            var token = _tokenService.GenerateToken();
            return new Token(token.Id, token.DataExpiracao, token.Valido);
        }

        public bool ValidateToken(Guid token)
        {
            var result = _tokenService.ValidateToken(token);
            return result;
        }
    }
}

