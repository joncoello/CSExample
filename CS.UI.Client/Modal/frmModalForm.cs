using CS.UI.Common.FormFactory;
using MYOB.CSSInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS.UI.Client.Modal
{
    public partial class frmModalForm : Form, ICSSDisplayModalForm
    {
        public frmModalForm(ModalForm factory)
        {
            InitializeComponent();
        }

        public int CollectionID { get; set; }

        public void CloseForm(object sender, CSSCancelEventArgs e)
        {
            
        }

        public PropertyBag Display()
        {
            this.ShowDialog();
            return new PropertyBag();
        }

        public SideBarGroups Register()
        {
            return new SideBarGroups(string.Empty);
        }
    }
}
