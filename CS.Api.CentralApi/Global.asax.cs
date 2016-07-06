using System.Web.Http;

namespace CS.Api.CentralApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutoMapperConfig.Configure();
            AutofacConfig.Register();
        }
    }
}
