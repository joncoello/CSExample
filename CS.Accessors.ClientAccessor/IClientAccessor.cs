using System.Collections.Generic;
using System.Threading.Tasks;
using CS.App.Models;

namespace CS.Accessors.ClientAccessor
{
    public interface IClientAccessor
    {
        Task<IEnumerable<ClientSupplierAppModel>> GetAllClientsAsync();
        Task<ClientSupplierAppModel> GetClientById(int clientId);
        void Save();
    }
}