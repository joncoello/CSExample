using System;
using System.Collections.Generic;
using CS.Data.Base;
using CS.Data.Model;

namespace CS.Repositories.ClientRepository
{
    public interface IClientRepository : IEntityRepository<ClientSupplier>
    {
       IEnumerable<SH_Search_Clients_Result> GetSearchResult(
            string searchText, 
            int? employeeId, 
            int? searchOnly, 
            int? includeClosed,
            int? businessType, 
            bool? includeDraft);
    }
}