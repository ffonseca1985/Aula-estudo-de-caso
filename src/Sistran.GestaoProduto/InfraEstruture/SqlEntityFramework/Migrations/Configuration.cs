namespace Sistran.GestaoProduto.InfraEstruture.SqlEntityFramework.Migrations
{
    using DomainModel.Produto;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Sistran.GestaoProduto.InfraEstruture.SqlEntityFramework.GestaoProdutoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"InfraEstruture\SqlEntityFramework\Migrations";
        }

        protected override void Seed(GestaoProdutoContext context)
        {
            var produto1 = new Produto("Produto1", "Descricao1", 10.0M);
            var produto2 = new Produto("Produto2", "Descricao2", 9.0M);
            var produto3 = new Produto("Produto3", "Descricao3", 9.0M);
            var produto4 = new Produto("Produto4", "Descricao4", 8.0M);
            var produto5 = new Produto("Produto5", "Descricao5", 7.0M);

            Produto[] produtos = new Produto[] { produto1, produto2, produto3, produto4, produto5 };

            context.Produto.AddOrUpdate(x => x.Nome, produtos);
            context.SaveChanges();
        }
    }
}
