using CS.Data.Base;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using CS.Data.Model;

namespace CS.Data.Context
{
    public interface IClientContext<T> : IContext<T> where T : class
    {
        IDbSet<ClientSupplier> ClientSuppliers { get; set; }
        IDbSet<ClientSupplierType> ClientSupplierTypes { get; set; }
        IDbSet<ClientVATType> ClientVATTypes { get; set; }

        ObjectResult<SH_Search_Clients_Result> SH_Search_Clients(
            string searchText, 
            int? employeeId,
            int? searchOnly, 
            int? includeClosed, 
            int? businessType,
            bool? includeDraft);
    }

    public partial class ClientContext : BaseContext<ClientContext>, IClientContext<ClientContext>
    {   
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual IDbSet<ClientSupplier> ClientSuppliers { get; set; }
        public virtual IDbSet<ClientSupplierType> ClientSupplierTypes { get; set; }
        public virtual IDbSet<ClientVATType> ClientVATTypes { get; set; }
    
        public virtual ObjectResult<SH_Search_Clients_Result> SH_Search_Clients(string searchText, Nullable<int> employeeId, Nullable<int> searchOnly, Nullable<int> includeClosed, Nullable<int> businessType, Nullable<bool> includeDraft)
        {
            var searchTextParameter = searchText != null ?
                new ObjectParameter("SearchText", searchText) :
                new ObjectParameter("SearchText", typeof(string));
    
            var employeeIdParameter = employeeId.HasValue ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(int));
    
            var searchOnlyParameter = searchOnly.HasValue ?
                new ObjectParameter("SearchOnly", searchOnly) :
                new ObjectParameter("SearchOnly", typeof(int));
    
            var includeClosedParameter = includeClosed.HasValue ?
                new ObjectParameter("IncludeClosed", includeClosed) :
                new ObjectParameter("IncludeClosed", typeof(int));
    
            var businessTypeParameter = businessType.HasValue ?
                new ObjectParameter("BusinessType", businessType) :
                new ObjectParameter("BusinessType", typeof(int));
    
            var includeDraftParameter = includeDraft.HasValue ?
                new ObjectParameter("IncludeDraft", includeDraft) :
                new ObjectParameter("IncludeDraft", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SH_Search_Clients_Result>("SH_Search_Clients", searchTextParameter, employeeIdParameter, searchOnlyParameter, includeClosedParameter, businessTypeParameter, includeDraftParameter);
        }

        public void SetModified(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }
        public void SetAdd(object entity)
        {
            Entry(entity).State = EntityState.Added;
        }
    }
}
