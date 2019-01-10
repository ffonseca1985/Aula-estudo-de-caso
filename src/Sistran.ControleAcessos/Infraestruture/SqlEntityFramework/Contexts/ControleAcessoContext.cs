using Sistran.ControleAcessos.DomainModel.Token;
using Sistran.SharedKernel.Infraestructure.SqlEntityFramework;
using System.Data.Entity;

namespace Sistran.ControleAcessos.Infraestruture.SqlEntityFramework.Contexts
{
    public class ControleAcessoContext
        : DbContextBase
    {
        public ControleAcessoContext() 
            : base("ConnectionDB")
        {}
        public DbSet<Token> Token { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
