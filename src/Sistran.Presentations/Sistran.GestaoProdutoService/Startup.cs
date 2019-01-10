using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using Newtonsoft.Json.Serialization;
using Microsoft.Owin.Cors;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using Sistran.GestaoProduto.InfraEstruture.ServiceLocator;

[assembly: OwinStartup(typeof(Sistran.GestaoProdutoService.Startup))]

namespace Sistran.GestaoProdutoService
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var configuration = new HttpConfiguration();

            this.ConfigurarFormatoRetorno(configuration);
            this.ConfigurarRota(configuration);
            this.ConfigureServiceLocator(configuration);

            app.UseCors(CorsOptions.AllowAll);
            app.UseWebApi(configuration);
        }

        private void ConfigureServiceLocator(HttpConfiguration configuration)
        {
            var container = new Container();
            
            container.Options.DefaultScopedLifestyle = new SimpleInjector.Lifestyles.AsyncScopedLifestyle();
            var lifestyle = new SimpleInjector.Lifestyles.AsyncScopedLifestyle();

            container.Initialize(lifestyle);

            container.RegisterWebApiControllers(configuration);
            container.Verify();

            configuration.DependencyResolver =
                    new SimpleInjectorWebApiDependencyResolver(container);
        }

        private void ConfigurarFormatoRetorno(HttpConfiguration configuration)
        {
            configuration.Formatters.Remove(configuration.Formatters.XmlFormatter);

            var settings = configuration.Formatters.JsonFormatter.SerializerSettings;
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }

        private void ConfigurarRota(HttpConfiguration configuration)
        {
            configuration.MapHttpAttributeRoutes();
        }
    }
}
