using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS.UI.Homepage.AnotherWidget
{
    public partial class ctlAnotherWidget : Homepagebase
    {
        public ctlAnotherWidget()
        {
            InitializeComponent();
        }

        public override string DisplayName
        {
            get
            {
                return "Another widget";
            }
        }

    }
}
