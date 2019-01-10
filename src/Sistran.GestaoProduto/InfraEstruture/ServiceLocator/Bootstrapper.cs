using SimpleInjector;
using Sistran.GestaoProduto.Application.Produto;
using Sistran.GestaoProduto.Application.Token;
using Sistran.GestaoProduto.DomainModel.Produto;
using Sistran.GestaoProduto.InfraEstruture.SqlEntityFramework;
using Sistran.SharedKernel.Infraestructure.SqlEntityFramework;
using System.Data.Entity;

namespace Sistran.GestaoProduto.InfraEstruture.ServiceLocator
{
    using ACL = AntiCorruptionLayer;
    public static class Bootstrapper
    {
        public static void Initialize(this Container container, Lifestyle lifestyle)
        {
            container.Register<DbContext, GestaoProdutoContext>(lifestyle);
            container.Register<RepositoryBase<Produto>>(lifestyle);
            container.Register<ProdutoService>(lifestyle);
            container.Register<TokenService>(lifestyle);
            container.Register<ACL.TokenService>(lifestyle);
        }
    }
}
