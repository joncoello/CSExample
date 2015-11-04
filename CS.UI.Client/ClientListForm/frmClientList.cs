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
using CS.DomainModel.Models.Documents;

namespace CS.UI.Client.ClientListForm
{
    public partial class frmClientList : Form, ICSSDisplayMainArea
    {
        public frmClientList(ClientList factory)
        {
            InitializeComponent();

            Guid id = factory.Arg1;
        }

        public int CollectionID { get; set; }

        public void CloseForm(object sender, CSSCancelEventArgs e)
        {
            this.Close();
        }

        public SideBarGroups Register()
        {
            this.Show(); // must do this

            var sbgs = new SideBarGroups("ClientList");

            var group1 = sbgs.Add("Group 1");
            var sbi = group1.Add("Item 1", 0, SidebarClicked);

            return sbgs;

        }

        private void SidebarClicked(object Sender, SideBarEventArgs e)
        {
            MessageBox.Show("CLicked!");
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            InitGrid();
            LoadData();

            var f = new CS.UI.Maintenance.DataAPIForm.frmDataAPI(null);

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

        private void button1_Click(object sender, EventArgs e)
        {
            string plainText = textBox1.Text;
            string encrypted = CssContext.Instance.Host.Encrypt(plainText);
            MessageBox.Show(encrypted);
            plainText = CssContext.Instance.Host.Decrypt(encrypted);
            MessageBox.Show(plainText);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CssContext.Instance.Host.OpenClient(18);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var pb = CssContext.Instance.Host.RegisterModalForm(new ModalForm());
        }

        private void txtBroadcast_TextChanged(object sender, EventArgs e)
        {
            var eArgs = new FrameworkEventArgs();
            eArgs.PropertyBag.Add("MyText", txtBroadcast.Text);
            CSSFormEventHandler.Instance.FrameWorkEvent("ClearSky.Example", "MyTextChanged", eArgs);
        }
    }
}
