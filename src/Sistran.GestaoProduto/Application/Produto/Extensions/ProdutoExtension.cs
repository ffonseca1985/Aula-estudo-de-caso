using Sistran.GestaoProduto.Application.Produto.Dtos;
using System.Collections.Generic;

namespace Sistran.GestaoProduto.Application.Produto.Extensions
{
    using DomainModel.Produto;
    public static class ProdutoExtension
    {
        public static ProdutoDto ToDto(this Produto produto)
        {
            return new ProdutoDto(produto.Id, produto.Nome, produto.Descricao, produto.Preco);
        }
        public static List<ProdutoDto> ToDto(this List<Produto> produtos)
        {
            return produtos.ConvertAll(ToDto);
        }
    }
}
