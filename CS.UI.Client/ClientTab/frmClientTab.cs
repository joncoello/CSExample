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

namespace CS.UI.Client.ClientTab
{
    public partial class frmClientTab : Form, ICSSClientFormPlugIn
    {
        public frmClientTab()
        {
            InitializeComponent();
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
            return true;
        }

        public void CloseForm(object sender, CSSChildEventArgs e)
        {
            
        }

        public void LoadClient(int ClientId, ICSSHost Host)
        {
            
        }

        public void RefreshForm()
        {
            
        }

        public void SaveChanges(object sender, CSSChildSaveEventArgs e)
        {
            
        }

        private void cmdUploadDocument_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.ShowDialog();
            }
        }
    }

}
