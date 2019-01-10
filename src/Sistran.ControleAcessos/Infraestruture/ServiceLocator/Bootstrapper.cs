using SimpleInjector;
using Sistran.ControleAcessos.Application.Token;
using Sistran.ControleAcessos.DomainModel.Token;
using Sistran.ControleAcessos.Infraestruture.SqlEntityFramework.Contexts;
using Sistran.SharedKernel.Infraestructure.SqlEntityFramework;
using System.Data.Entity;

namespace Sistran.ControleAcessos.Infraestruture.ServiceLocator
{
    public static class Bootstrapper
    {
        public static void Initialize(this Container container, Lifestyle lifestyle)
        {
            //container.Register<DbContext, ControleAcessoContext>(lifestyle);
            //container.Register<RepositoryBase<Token>>(lifestyle);
            container.Register<TokenService>(lifestyle);
        }
    }
}
