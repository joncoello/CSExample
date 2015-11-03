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

            ProductName = "Example";

            var mnuMaintenance = this.Add("mnuMaintenance", "Maintenance", MenuItemType.Group);

            var mnuClearSky = mnuMaintenance.Add("mnuClearSky", "ClearSky", CSSMenuItem.MenuItemType.Group);

            mnuClearSky.Add("mnuItem1", "Item 1", CSSMenuItem.MenuItemType.Item);
            mnuClearSky.Add("mnuDataAPI", "Data API", CSSMenuItem.MenuItemType.Item);

        }

        public override void PluginMenuClicked(object Sender, MenuEventArgs e)
        {
            switch (e.Key)
            {
                case "mnuItem1":
                    var formToLoad1 = new FormFactory.PortalIntegration();
                    CssContext.Instance.Host.Register(formToLoad1);
                    break;
                case "mnuDataAPI":
                    var formToLoad2 = new FormFactory.DataAPI();
                    CssContext.Instance.Host.Register(formToLoad2);
                    break;
            }
        }

    }

}
