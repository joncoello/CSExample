using MYOB.CSS;
using MYOB.CSSInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS.UI.Common
{
    public class Menus : CSSMenus
    {

        public Menus()
        {

            // set product name - mu have it in
            ProductName = "Example";


            var mnuMaintenance = this.Add("mnuMaintenance", "Maintenance", MenuItemType.Group);

            var mnuCS = mnuMaintenance.Add("mnuCS", "CS", CSSMenuItem.MenuItemType.Group);

            mnuCS.Add("mnuItem1", "Portal Integration", CSSMenuItem.MenuItemType.Item);
            mnuCS.Add("mnuItem2", "Item 2", CSSMenuItem.MenuItemType.Item);
            mnuCS.Add("mnuDataAPI", "Data API", CSSMenuItem.MenuItemType.Item);

        }

        public override void PluginMenuClicked(object Sender, MenuEventArgs e)
        {
            switch (e.Key)
            {
                case "mnuItem1":
                    var formToLoad1 = new FormFactory.PortalIntegration();
                    CssContext.Instance.Host.Register(formToLoad1);
                    break;


                case "mnuItem2":
                    var formToLoad3 = new FormFactory.ClientList(Guid.NewGuid());
                    CssContext.Instance.Host.Register(formToLoad3);
                    break;



                case "mnuDataAPI":
                    var formToLoad2 = new FormFactory.DataAPI();
                    CssContext.Instance.Host.Register(formToLoad2);
                    break;
            }
        }

    }

}
