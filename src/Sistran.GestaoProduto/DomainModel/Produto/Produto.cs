using Sistran.SharedKernel.DomainModel;
using System;

namespace Sistran.GestaoProduto.DomainModel.Produto
{
    public class Produto : AggregateRoot
    {
        private Produto() {}
        public Produto(string nome, string descricao, decimal preco)
        {

            this.Id = Guid.NewGuid();
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
        }
        
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal Preco { get; private set; }
    }
}
