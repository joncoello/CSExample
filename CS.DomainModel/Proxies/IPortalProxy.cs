using CS.DomainModel.Models.Portal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.DomainModel.Proxies
{
    public interface IPortalProxy
    {
        IEnumerable<Client> GetClients();
        void DownloadDocument(Document document);
    }
}
