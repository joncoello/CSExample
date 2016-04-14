using System;
using System.ServiceModel;

namespace CS.UI.Client
{
    internal class ActionListener
    {
        private ServiceHost _host;

        internal void Start()
        {
            string uri = "net.pipe://localhost/central";
            _host = new ServiceHost(typeof(ActionManager), new Uri(uri));
            
            _host.Open();

        }

        internal void Stop()
        {
            _host.Close();
        }

    }

}