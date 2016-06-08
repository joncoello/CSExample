using AutoMapper;
using CS.Common.AutoMapper.Profiles;

namespace CS.Common.AutoMapper
{
    public static class AutoMapperConfiguration
    {
        public static void Configure(IConfiguration config)
        {
            config.AddProfile(new ClientProfile());
        }
    }
}
