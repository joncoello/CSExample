using System.Web.Http;

namespace CS.Client.CentralApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutoMapperWebConfiguration.Configure();
        }
    }
}
