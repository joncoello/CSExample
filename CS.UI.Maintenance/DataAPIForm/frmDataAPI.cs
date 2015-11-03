using Central.CSSContactAPI;
using CS.UI.Common.FormFactory;
using MYOB.CSS;
using MYOB.CSSInterface;
using MYOB.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS.UI.Maintenance.DataAPIForm
{
    public partial class frmDataAPI : Form, ICSSDisplayMainArea
    {
        private DAL _centralDal;
        private CentralGateway _gateway;

        public frmDataAPI(DataAPI factory)
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
            return new SideBarGroups(string.Empty);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _centralDal = CssContext.Instance.GetDAL(string.Empty) as DAL;
            _gateway = new CentralGateway(_centralDal);

        }

        private void cmdCreateIndividual_Click(object sender, EventArgs e)
        {
            
            var i = new Individual() {
                LastName = "Smith" 
            };

            _gateway.Save(i);

            CssContext.Instance.Host.OpenContact(i.ContactId);

        }

    }
}
