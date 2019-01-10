namespace Sistran.ControleAcessos.Application.Token
{
    using DomainModel.Token;
    using Dto;
    using Extensions;
    using SharedKernel.Infraestructure.SqlEntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public sealed class TokenService
    {
        private RepositoryBase<Token> _repositoryToken;
        private static List<Token> _tokens;

        //public TokenService(RepositoryBase<Token> repositoryToken)
        public TokenService()
        {
            //_repositoryToken = repositoryToken;

            if (_tokens == null)
                _tokens = new List<Token>();
        }

        public TokenDto GenerateToken()
        {
            var token = new Token();
            //_repositoryToken.Add(token);
            _tokens.Add(token);

            return token.ToDto();
        }

        public bool ValidateToken(Guid idToken)
        {
            //var token = _repositoryToken.FindById(idToken);
            var token = _tokens.FirstOrDefault(x=>x.Id == idToken);

            if (token == null)
                return false;

            return token.Valido;
        }
    }
}
