
namespace Sistran.GestaoProduto.Application.Token
{
    using Dtos;
    using ACL = InfraEstruture.AntiCorruptionLayer;
    using Extensions;

    public class TokenService
    {
        ACL.TokenService _tokenService;
        public TokenService(ACL.TokenService tokenService)
        {
            _tokenService = tokenService;
        }

        public TokenDto Create()
        {
            return _tokenService.Create().ToDto();
        }   
    }
}
