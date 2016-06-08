using AutoMapper;
using CS.Common.AutoMapper;

namespace CS.Client.CentralApi
{
    public static class AutoMapperConfig
    {
        public static MapperConfiguration Config;
        public static void Configure()
        {
            Config = new MapperConfiguration(cfg =>{});

            var profileConfig = (IConfiguration) Config;
            AutoMapperConfiguration.Configure(profileConfig);
        }
    }
}