using Sistran.GestaoProduto.DomainModel.Produto;
using System.Data.Entity.ModelConfiguration;

namespace Sistran.GestaoProduto.InfraEstruture.SqlEntityFramework.Maps
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            this.HasKey(x => x.Id);

            this.Property(x => x.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(500);

            this.Property(x => x.Descricao)
                .HasColumnType("varchar")
                .HasMaxLength(500);
        }
    }
}
