using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS.UI.Common.FormFactory;
using MYOB.CSSInterface;
using MYOB.CSS;
using Janus.Windows.GridEX;

namespace CS.UI.Client.ClientListForm
{
    public partial class frmClientList : Form, ICSSDisplayMainArea
    {
        public frmClientList(ClientList factory)
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

            InitGrid();
            LoadData();

        }

        private void InitGrid()
        {

            GridEXColumn col;

            var rt = new GridEXTable();

            grdList.RootTable = rt;

            rt.Columns.Add("Name");
            rt.Columns.Add("Field1");
            rt.Columns.Add("Field2");

            CssContext.Instance.Host.Personalisation.RestoreGridLayout("mygrid", grdList);
        }

        private void LoadData()
        {
            var data = new DataTable();
            grdList.SetDataBinding(data, string.Empty);
        }

    }
}
