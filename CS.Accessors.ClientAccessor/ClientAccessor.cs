using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CS.App.Models;
using CS.Data.Base;
using CS.Data.Context;
using CS.Repositories.ClientRepository;

namespace CS.Accessors.ClientAccessor
{
    public class ClientAccessor : IClientAccessor
    {
        private readonly IUnitOfWork<ClientContext> _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IClientRepository _repository;

        public ClientAccessor(IUnitOfWork<ClientContext> unitOfWork, IClientRepository repository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _repository = repository;
        }
        
        public async Task<IEnumerable<ClientSupplierAppModel>> GetAllClientsAsync()
        {
            var result = await _repository.AllAsync();
            var appModel = _mapper.Map<IEnumerable<ClientSupplierAppModel>>(result);
            return appModel;
        }

        public async Task<ClientSupplierAppModel> GetClientById(int clientId)
        {
            var result = await _repository.Find(clientId);
            var appModel = _mapper.Map<ClientSupplierAppModel>(result);
            return appModel;
        }

        public void Save()
        {
            _unitOfWork.Save();
        }
    }
}
