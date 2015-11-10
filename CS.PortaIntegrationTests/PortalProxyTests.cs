using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CS.PortaIntegration;

namespace CS.PortaIntegrationTests
{
    [TestClass]
    public class PortalProxyTests
    {
        [TestMethod]
        public void PortalPoxy_Create()
        {
            var sut = CreatePortalProxy();
        }

        [TestMethod]
        public void PortalPoxy_GetClients()
        {
            var sut = CreatePortalProxy();
            var clients = sut.GetClients();
        }

        private PortalProxy CreatePortalProxy() {
            string baseUrl = "https://cchcs01.clientspace.co.uk";
            var practiceGuid = Guid.Parse("e5e86e6c-15e0-4e47-85fd-deb7180c1c2d");
            string emailAddress = "jon.coello@wolterskluwer.co.uk";
            string password = "1";
            return new PortalProxy(baseUrl, practiceGuid, emailAddress, password);
        }

    }
}
