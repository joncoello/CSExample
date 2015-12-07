using CS.DomainModel.Models.Portal;
using CS.DomainModel.Services;
using CS.PortaIntegration;
using CS.UI.Common.FormFactory;
using Janus.Windows.GridEX;
using MYOB.CSSInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CS.UI.Maintenance.PortalIntegrationForm
{
    public partial class frmPortalIntegration : Form, ICSSDisplayMainArea
    {
        private PortalService _portalService;

        public frmPortalIntegration(PortalIntegration factory)
        {
            InitializeComponent();
        }

        public int CollectionID { get; set; }

        public void CloseForm(object sender, CSSCancelEventArgs e)
        {
            this.Close();
        }

        public SideBarGroups Register()
        {
            this.Show();
            return new SideBarGroups("");
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LoadData();
        }

        private void LoadData()
        {
            var portalProxy = new PortalProxy(txtUrl.Text, Guid.Parse(txtPracticeGuid.Text), txtUserName.Text, txtPassword.Text);
            _portalService = new PortalService(portalProxy);
            grdClients.SetDataBinding(_portalService.GetClients(), string.Empty);
            grdClients.RetrieveStructure();
        }

        private void grdClients_SelectionChanged(object sender, EventArgs e)
        {
            var client = (grdClients.GetRow().DataRow as Client);
            grdFolders.SetDataBinding(client.Folders, string.Empty);
            grdFolders.RetrieveStructure();
            //grdFolders_SelectionChanged(null, EventArgs.Empty);
        }

        private void grdFolders_SelectionChanged(object sender, EventArgs e)
        {
            var folder = (grdFolders.GetRow().DataRow as DocumentFolder);
            grdDocuments.SetDataBinding(folder.Documents, string.Empty);
            grdDocuments.RetrieveStructure();
            grdDocuments.RowHeaders = InheritableBoolean.True;

            foreach (GridEXColumn col in grdDocuments.RootTable.Columns)
            {
                col.EditType = EditType.NoEdit;
                col.Selectable = false;
            }

        }

        private void grdDocuments_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            var document = grdDocuments.GetRow().DataRow as Document;

            using (var sfd = new SaveFileDialog())
            {

                sfd.FileName = document.Name;

                sfd.ShowDialog();

                var cursor = this.Cursor;
                this.Cursor = Cursors.WaitCursor;
                _portalService.DownloadDocument(document, sfd.FileName);
                this.Cursor = cursor;

            }
                            
        }

    }
}
