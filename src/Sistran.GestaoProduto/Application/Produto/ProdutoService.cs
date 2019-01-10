using Sistran.GestaoProduto.Application.Produto.Dtos;
using Sistran.SharedKernel.Infraestructure.SqlEntityFramework;
using System.Collections.Generic;
using System.Linq;

namespace Sistran.GestaoProduto.Application.Produto
{
    using DomainModel.Produto;
    using Extensions;
    using InfraEstruture.AntiCorruptionLayer;
    using System;

    public class ProdutoService
    {
        RepositoryBase<Produto> _produtoRepository;
        TokenService _tokenService;

        public ProdutoService(
            RepositoryBase<Produto> produtoRepository,
            TokenService tokenService)
        {
            _produtoRepository = produtoRepository;
            _tokenService = tokenService;
        }

        public IEnumerable<ProdutoDto> Get()
        {
            var produtos = _produtoRepository.Get();
            return produtos.ToList().ToDto();
        }

        public IEnumerable<ProdutoDto> Get(Guid idToken)
        {
            bool tokenValido = _tokenService.Validate(idToken);

            if (tokenValido)
                return _produtoRepository.Get().ToList().ToDto();
            
            return new List<ProdutoDto>();
        }
    }
}
