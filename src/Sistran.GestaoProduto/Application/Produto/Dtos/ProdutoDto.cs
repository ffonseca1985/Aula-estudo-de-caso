using System;

namespace Sistran.GestaoProduto.Application.Produto.Dtos
{
    public class ProdutoDto
    {
        public ProdutoDto(Guid id, 
            string nome, 
            string descricao, 
            decimal preco)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Preco = preco;
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal Preco { get; private set; }
    }
}
