using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.DomainModel.Models.Portal
{
    public class DocumentFolder
    {
        public IEnumerable<Document> Documents { get; set; }
        public string DocumentsLink { get; set; }
        public Guid FolderGuid { get; set; }
        public string Name { get; set; }
    }
}
