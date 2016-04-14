using MYOB.CSS;
using MYOB.CSSInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS.UI.Client
{
    public class CentralApplication : CSSApplication
    {
        private ActionListener _listener;

        public CentralApplication()
        {
            this.Startup += CentralApplication_Startup;
            this.ShutDown += CentralApplication_ShutDown;
        }
        
        private void CentralApplication_Startup(object sender, EventArgs e)
        {
            CSSFormEventHandler.Instance.AddHandle(CSSFormEventHandler.CSSEventArea.Contact, CSSFormEventHandler.CSSFormEvent.Loading, ContactLoading);
            CSSFormEventHandler.Instance.AddHandle(CSSFormEventHandler.CSSEventArea.Contact, CSSFormEventHandler.CSSFormEvent.Closed, ContactClosed);

            //StartActionListener();

        }


        private void CentralApplication_ShutDown(object sender, EventArgs e)
        {
            CSSFormEventHandler.Instance.RemoveHandle(CSSFormEventHandler.CSSEventArea.Contact, CSSFormEventHandler.CSSFormEvent.Loading, ContactLoading);
            CSSFormEventHandler.Instance.RemoveHandle(CSSFormEventHandler.CSSEventArea.Contact, CSSFormEventHandler.CSSFormEvent.Closed, ContactClosed);

            StopActionListener();
        }
        
        private void ContactLoading(object sender, EventArgs e)
        {
            var eArgs = e as FrameworkEventArgs;
            if (eArgs != null)
            {
                MessageBox.Show($"CS plugin hooked contact {eArgs.PropertyBag.ContactId} loading");
            }
        }

        private void ContactClosed(object sender, EventArgs e)
        {
            var eArgs = e as FrameworkEventArgs;
            if (eArgs != null)
            {
                MessageBox.Show($"CS plugin hooked contact {eArgs.PropertyBag.ContactId} closed");
            }
        }
        
        private void StartActionListener()
        {
            if (_listener == null)
            {
                _listener = new ActionListener();
            }
            _listener.Start();
        }
        private void StopActionListener()
        {
            if (_listener != null)
            {
                _listener.Stop();
            }
        }
        
    }
}
