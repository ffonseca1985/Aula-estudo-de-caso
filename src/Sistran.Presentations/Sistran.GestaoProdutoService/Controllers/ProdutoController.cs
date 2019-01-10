using Sistran.GestaoProduto.Application.Produto;
using System;
using System.Linq;
using System.Web.Http;

namespace Sistran.GestaoProdutoService.Controllers
{
    [RoutePrefix("api/produto")]
    public class ProdutoController : ApiController
    {
        private ProdutoService _produtoService;
        public ProdutoController(ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }
        
        [Route("")]
        public IHttpActionResult Get()
        {
            try
            {
                var produtos = _produtoService.Get();
                return Ok(produtos);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [Route("token/{idToken}")]
        public IHttpActionResult Get(Guid idToken)
        {
            try
            {
                var produtos = _produtoService.Get(idToken);
                return Ok(produtos);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
