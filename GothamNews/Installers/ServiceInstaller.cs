using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using GothamNews.Contracts;
using GothamNews.Logging;
using GothamNews.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace GothamNews.Installers
{
    public class ServiceInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            container.Register(
            Component.For<LoggingInterceptor>(),
            Component.For<INewsService>()
             .ImplementedBy<NewsService>()
             .Interceptors<LoggingInterceptor>());
        }
    }
}