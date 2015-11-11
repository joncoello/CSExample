using CS.DomainModel.Models.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.DomainModel.Repositories
{
    public interface IDocumentRepository
    {
        IEnumerable<Document> GetDocuments();
        void DownloadDocument(int documentID, string path);
        void UploadDocument(string path);

    }
}
