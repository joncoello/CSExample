using CS.DomainModel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS.DomainModel.Models.Documents;
using WKUK.CCH.Document.DocMgmt.DocManager;

namespace CS.DocumentRepository
{
    public class CCHDocumentRepository : IDocumentRepository
    {

        private readonly DocManager _cchDocumentAPI;
        private readonly int _contactID;

        public CCHDocumentRepository(DocManager cchDocumentAPI, int contactID)
        {
            _cchDocumentAPI = cchDocumentAPI;
            _contactID = contactID;
        }

        public void DownloadDocument(int documentID)
        {
            var doc = _cchDocumentAPI.RetrieveDocumentEntityFromID(documentID);
            _cchDocumentAPI.GetDocumentFromFileStore(doc, WKUK.CCH.Document.DocMgmt.Entities.CommonEnums.DocumentVersionControlStatus.CheckedIn);
        }

        public IEnumerable<Document> GetDocuments()
        {
            var docs = _cchDocumentAPI.RetrieveMostRecentDocumentListForContactClientAssignment(_contactID, 0, 7);

           return docs.Select(d => new Document() {
               DocumentID = d.DocumentId,
               Name = d.Name
            });
        }
    }
}
