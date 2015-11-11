using MYOB.CSSInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.UI.Common.FormFactory
{
    public class ClientList : FrameworkForm
    {

        [SkipFrameworkComparision]
        public Guid Arg1 { get; set; }

        public ClientList(Guid myarg1)
        {
            Arg1 = myarg1;
        }

        protected override string AssemblyName
        {
            get
            {
                return "CS.UI.Client.ClientListForm";
            }
        }

        protected override string ClassName
        {
            get
            {
                return "frmClientList";
            }
        }
    }
}
