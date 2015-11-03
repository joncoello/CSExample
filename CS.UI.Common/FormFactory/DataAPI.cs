using MYOB.CSSInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.UI.Common.FormFactory
{
    public class DataAPI : FrameworkForm
    {
        protected override string AssemblyName
        {
            get
            {
                return "CS.UI.Maintenance.DataAPIForm";
            }
        }

        protected override string ClassName
        {
            get
            {
                return "frmDataAPI";
            }
        }
    }
}
