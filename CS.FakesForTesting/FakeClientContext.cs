using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using CS.Data.Context;
using CS.Data.Model;

namespace CS.FakesForTesting
{
    public class FakeClientContext : ClientContext, IClientContext<FakeClientContext>
    {
        public FakeClientContext()
        {
            ClientSuppliers = new FakeClientDbSet();
        }
        
        public sealed override IDbSet<ClientSupplier> ClientSuppliers {get;set; }
        //public IDbSet<ClientSupplierType> ClientSupplierTypes { get; set; }
        //public IDbSet<ClientVATType> ClientVATTypes { get; set; }

        //public ObjectResult<SH_Search_Clients_Result> SH_Search_Clients(string searchText, int? employeeId, int? searchOnly, int? includeClosed,
        //    int? businessType, bool? includeDraft)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public void Dispose()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public int SaveChanges()
        //{
        //    throw new NotImplementedException();
        //}

        //public void SetModified(object entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void SetAdd(object entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
