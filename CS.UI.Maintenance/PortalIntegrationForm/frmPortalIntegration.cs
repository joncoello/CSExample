using CS.DomainModel.Services;
using CS.PortaIntegration;
using CS.UI.Common.FormFactory;
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
            var protalService = new PortalService(portalProxy);
            gridEX1.SetDataBinding(protalService.GetClients(), string.Empty);
            gridEX1.RetrieveStructure();
        }

    }
}
