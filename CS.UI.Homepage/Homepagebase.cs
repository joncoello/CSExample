using MYOB.CSSInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CS.UI.Homepage
{
    public class Homepagebase : HomePageItem
    {

        internal Homepagebase()
        {

        }

        public override string ApplicationName
        {
            get
            {
                return "Clear Sky";
            }
        }

        public override string DisplayName
        {
            get
            {
                return null;
            }
        }

        public override void DefaultSettings()
        {
            
        }

        public override void LoadData(bool Cache, bool StartNewThread)
        {
            
        }

        public override void RestoreCustomisation(XmlElement Customisation)
        {
            
        }

        public override void SaveCustomisation(XmlTextWriter XW)
        {
            
        }
    }
}
