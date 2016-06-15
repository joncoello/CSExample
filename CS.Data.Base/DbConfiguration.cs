using System.Configuration;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;

namespace CS.Data.Base
{
    public class DbConfiguration : System.Data.Entity.DbConfiguration
    {
        public DbConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new DefaultExecutionStrategy() );
            //TODO dont use config manager straight away like below. this is just a sample app
            SetDefaultConnectionFactory(new LocalDbConnectionFactory("mssqllocaldb",ConfigurationManager.ConnectionStrings["ClientContext"].ConnectionString));
            SetProviderServices("System.Data.SqlClient",
                SqlProviderServices.Instance);
        }
    }
}