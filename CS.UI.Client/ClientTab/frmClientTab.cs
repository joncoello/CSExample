using Central.CSSContactAPI;
using CS.DocumentRepository;
using CS.DomainModel.Models.Documents;
using Janus.Windows.GridEX;
using MYOB.CSS;
using MYOB.CSSInterface;
using MYOB.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WKUK.CCH.Document.DocMgmt.DocManager;

namespace CS.UI.Client.ClientTab
{
    public partial class frmClientTab : Form, ICSSClientFormPlugIn, ICSSChildSideBarItems
    {
        private CCHDocumentRepository _documentRepo;

        public frmClientTab()
        {
            InitializeComponent();
            this.Text = "Client Tax";
        }




        public int Position
        {
            get
            {
                return 3;
            }
        }

        public bool CheckSecurityPermission(AvailableArea Origin)
        {
            return CssContext.Instance.Host.HasAuthority("can make tea");
        }

        public void CloseForm(object sender, CSSChildEventArgs e)
        {
            
        }

        public void LoadClient(int ClientId, ICSSHost Host)
        {
            // construct APIs
            var centralDal = CssContext.Instance.GetDAL(string.Empty) as DAL;
            var docManager = new DocManager(centralDal);
            var centralGateway = new CentralGateway(centralDal);
            var client = centralGateway.FindClient(ClientId, CssContext.Instance.Host.EmployeeId);
            _documentRepo = new CCHDocumentRepository(docManager, client.Contact.ContactId);
            RefreshData();

        }

        private void RefreshData()
        {
            var documents = _documentRepo.GetDocuments().ToList();

            grdList.SetDataBinding(documents, string.Empty);
        }

        public void RefreshForm()
        {
            RefreshData();
        }

        public void SaveChanges(object sender, CSSChildSaveEventArgs e)
        {
            
        }
        
        private void cmdUploadDocument_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                if(ofd.ShowDialog()== DialogResult.OK)
                {
                    string fileName = ofd.FileName;
                    _documentRepo.UploadDocument(fileName);
                    RefreshData();
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            InitGrid();
        }
        
        private void InitGrid()
        {
            GridEXColumn col;
            var rt = new GridEXTable();

            col = rt.Columns.Add("DocumentID");
            col.EditType = EditType.NoEdit;
            col.Selectable = false;

            col = rt.Columns.Add("Name");
            col.EditType = EditType.NoEdit;
            col.Selectable = false;

            grdList.RootTable = rt;
            grdList.ColumnAutoResize = true;

            CssContext.Instance.Host.Personalisation.RestoreGridLayout("uniquestringforgrid", grdList);

        }

        private void grdList_RowDoubleClick(object sender, RowActionEventArgs e)
        {
            var document = grdList.GetRow().DataRow as Document;
            if (document != null)
            {
                string downloadPath = Path.Combine(Path.GetTempPath(), "CCHDocuments", document.Name);
                string directory = Path.GetDirectoryName(downloadPath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                _documentRepo.DownloadDocument(document.DocumentID, directory);
                Process.Start(downloadPath);
            }
        }

        public SideBarGroup[] GetSideBarItems()
        {
            var sbgs = new SideBarGroup[1];

            sbgs[0] = new SideBarGroup();
            sbgs[0].Name = "Group 1";
            sbgs[0].Add("Item 1", 0, SidebarCLicked);

            return sbgs;
        }

        private void SidebarCLicked(object Sender, SideBarEventArgs e)
        {
            MessageBox.Show("Test");
        }
    }

}
