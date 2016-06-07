using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CS.Data.Base;
using CS.Data.Context;
using CS.Data.Model;

namespace CS.Repositories.ClientRepository
{
    public class ClientRepository : IClientRepository
    {
        private readonly IClientContext _context;
        public ClientRepository(IUnitOfWork unitOfWork)
        {
            _context = unitOfWork.Context as IClientContext;
        }

        public void Dispose()
        {
        }

        public async Task<IEnumerable<ClientSupplier>> AllAsync()
        {
            var result =  await _context.ClientSuppliers.ToListAsync();

            return result; 
        } 

        public IQueryable<ClientSupplier> AllIncluding(params Expression<Func<ClientSupplier, object>>[] includeProperties)
        {
            IQueryable<ClientSupplier> query = _context.ClientSuppliers;
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Task<ClientSupplier> Find(int id)
        {
            return Task.FromResult(_context.ClientSuppliers.Find(id));
        }

        public void InsertOrUpdate(ClientSupplier entity)
        {
            if (entity.ClientID == default(int)) 
            {
                _context.SetAdd(entity);
            }
            else        
            {
                _context.SetModified(entity);
            }
        }

        public void Delete(int id)
        {
            var client = _context.ClientSuppliers.Find(id);
            _context.ClientSuppliers.Remove(client);
        }

        public IEnumerable<SH_Search_Clients_Result> GetSearchResult(
            string searchText, 
            int? employeeId, 
            int? searchOnly, 
            int? includeClosed,
            int? businessType, 
            bool? includeDraft)
        {
            return _context.SH_Search_Clients(
                searchText,
                employeeId,
                searchOnly,
                includeClosed, 
                businessType, 
                includeDraft).ToList();
        }
    }
}
