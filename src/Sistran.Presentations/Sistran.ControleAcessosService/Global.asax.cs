using SimpleInjector;
using SimpleInjector.Integration.Wcf;
using System;
using Sistran.ControleAcessos.Infraestruture.ServiceLocator;

namespace Sistran.ControleAcessosService
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            var container = new Container();

            container.Options.DefaultScopedLifestyle = new WcfOperationLifestyle();
            var lifestyle = new WcfOperationLifestyle();

            container.Initialize(lifestyle);

            SimpleInjectorServiceHostFactory.SetContainer(container);

            container.Verify();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}