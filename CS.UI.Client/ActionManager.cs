using MYOB.CSS;
using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Windows.Forms;

namespace CS.UI.Client
{
    internal class ActionManager : IActionManager
    {
        public void SendMessage(string message)
        {
            switch (message)
            {
                case "open":
                    CssContext.Instance.Host.OpenClient(571);
                    break;

                case "quit":
                    CssContext.Instance.Host.Logout();
                    Process.GetCurrentProcess().Kill();
                    break;

            }
        }
    }
}