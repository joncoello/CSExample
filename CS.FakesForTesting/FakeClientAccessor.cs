using System.Collections.Generic;
using System.Threading.Tasks;
using CS.Accessors.ClientAccessor;
using CS.App.Models;

namespace CS.FakesForTesting
{
    public class FakeClientAccessor : IClientAccessor
    {
        public Task<IEnumerable<ClientSupplierAppModel>> GetAllClientsAsync()
        {
            IEnumerable<ClientSupplierAppModel> model = new List<ClientSupplierAppModel>
            {
                new ClientSupplierAppModel {ClientID = 1},
                new ClientSupplierAppModel {ClientID = 2}
            };
            return Task.FromResult(model);
        }

        public Task<ClientSupplierAppModel> GetClientById(int clientId)
        {
            return null;
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }
    }
}