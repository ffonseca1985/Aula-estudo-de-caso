using Sistran.GestaoProduto.Application.Token;
using System;
using System.Web.Http;

namespace Sistran.GestaoProdutoService.Controllers
{
    [RoutePrefix("api/token")]
    public class TokenController : ApiController
    {
        TokenService _tokenService;
        public TokenController(TokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [Route("")]
        public IHttpActionResult Post()
        {
            try
            {
                var token = _tokenService.Create();
                return Ok(token);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
