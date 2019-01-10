using Sistran.GestaoProduto.DomainModel.Produto;
using Sistran.GestaoProduto.InfraEstruture.SqlEntityFramework.Maps;
using Sistran.SharedKernel.Infraestructure.SqlEntityFramework;
using System.Data.Entity;

namespace Sistran.GestaoProduto.InfraEstruture.SqlEntityFramework
{
    public class GestaoProdutoContext 
        : DbContextBase
    {
        public GestaoProdutoContext()
            :base("ConnectionDB")
        {
        }
        public DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProdutoMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
