using Autofac;
using CS.Accessors.ClientAccessor;
using CS.Data.Base;
using CS.Data.Context;
using CS.Repositories.ClientRepository;

namespace CS.Common.Autofac
{
    public static class AutofacRegistration
    {
        public static void Register(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(UnitOfWork<>))
                .As(typeof(IUnitOfWork<>))
                .InstancePerDependency();

            builder.RegisterType<ClientAccessor>()
                .As<IClientAccessor>().PropertiesAutowired();

            builder.RegisterType<ClientRepository>().As<IClientRepository>();
            builder.RegisterType<ClientContext>().As<IClientContext<ClientContext>>();

        }
    }
}
