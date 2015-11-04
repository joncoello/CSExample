using CS.DomainModel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS.DomainModel.Models.Documents;
using WKUK.CCH.Document.DocMgmt.DocManager;
using System.IO;

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

        public void DownloadDocument(int documentID, string path)
        {
            var document = _cchDocumentAPI.RetrieveDocumentEntityFromID(documentID);
            document.CheckOutPath = Path.Combine(path, document.Name);
            _cchDocumentAPI.GetDocumentFromFileStore(document, WKUK.CCH.Document.DocMgmt.Entities.CommonEnums.DocumentVersionControlStatus.CheckedIn);
        }

        public IEnumerable<Document> GetDocuments()
        {
            var docs = _cchDocumentAPI.RetrieveMostRecentDocumentListForContactClientAssignment(_contactID, 0, 7);

           return docs.Select(d => new Document() {
               DocumentID = d.DocumentId,
               Name = d.Name
            });
        }

        public void UploadDocument(string path)
        {
            var document = new WKUK.CCH.Document.DocMgmt.Entities.Document()
            {
                LocalPath = path,
                ImportedDocumentPath = path,
                Description = Path.GetFileName(path),
                DocumentTypeId = 6, // permanenent
                LibraryId = 3, // client
                CreatedDate = DateTime.Now,
                CreatedByContactId = 1,
                SourceId = 3,   
                Name = Path.GetFileName(path),
                SupressThumbnail = true,
            };
            document.ContactID = _contactID;
            var documents = new WKUK.CCH.Document.DocMgmt.Entities.DocumentCollection();
            documents.Add(document);
            _cchDocumentAPI.UploadAddedDocuments(documents, false, 0);
        }
    }
}
