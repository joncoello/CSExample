using AutoMapper;

namespace CS.Client.CentralApi
{
    public static class AutoMapperWebConfiguration
    {
        public static MapperConfiguration Config;
        public static void Configure()
        {
            Config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ClientProfile());
            });
        }
    }
}