using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using AutoMapper;
using CS.Common.Autofac;

namespace CS.Client.CentralApi
{
    public static class AutofacConfig
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();

            builder.Register(c => AutoMapperConfig.Config.CreateMapper()).As<IMapper>();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();

            AutofacRegistration.Register(builder);

            var container = builder.Build();
            
            var resolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
        }
    }
}