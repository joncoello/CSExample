using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS.DomainModel.Models.Portal;
using CS.DomainModel.Proxies;

namespace CS.DomainModel.Services
{
    public class PortalService : IPortalService
    {
        private readonly IPortalProxy _portalProxy;

        public PortalService(IPortalProxy portalProxy)
        {
            _portalProxy = portalProxy;
        }
        public IEnumerable<Client> GetClients()
        {
            return _portalProxy.GetClients();
        }

        public void DownloadDocument(Document document)
        {
            _portalProxy.DownloadDocument(document);
        }
    }
}
