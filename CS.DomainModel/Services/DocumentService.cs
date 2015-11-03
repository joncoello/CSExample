using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS.DomainModel.Models.Documents;
using CS.DomainModel.Repositories;

namespace CS.DomainModel.Services
{
    public class DocumentService : IDocumentService
    {
        private readonly IDocumentRepository _documentRepository;

        public DocumentService(IDocumentRepository documentRepository)
        {
            if (documentRepository == null)
            {
                throw new ArgumentNullException("documentRepository");
            }
            _documentRepository = documentRepository;
        }

        public IEnumerable<Document> GetDocuments()
        {
            return _documentRepository.GetDocuments();
        }
    }
}
