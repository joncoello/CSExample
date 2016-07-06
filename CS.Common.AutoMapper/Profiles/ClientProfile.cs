using AutoMapper;
using CS.App.Models;
using CS.Data.Model;

namespace CS.Common.AutoMapper.Profiles
{
    public class ClientProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<ClientSupplier, ClientSupplierAppModel>();
            CreateMap<ClientSupplierType, ClientSupplierTypeAppModel>();
            CreateMap<ClientVATType, ClientVATTypeAppModel>();
        }
    }
}