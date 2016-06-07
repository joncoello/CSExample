using AutoMapper;
using CS.Data.Model;

namespace CS.Client.CentralApi
{
    public class ClientProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<ClientSupplier, App.Models.ClientSupplierAppModel>();
            CreateMap<ClientSupplierType, App.Models.ClientSupplierTypeAppModel>();
            CreateMap<ClientVATType, App.Models.ClientVATTypeAppModel>();
        }
    }
}