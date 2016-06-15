using System.Data.Entity;


namespace CS.Data.Base
{
    [DbConfigurationType(typeof(DbConfiguration))]
    public class BaseContext<TContext> : DbContext where TContext : DbContext
    {
        static BaseContext()
        {
            Database.SetInitializer<TContext>(null);
        }
        //protected BaseContext()
        //  : base("name=ClientContext")
        //{ }
    }
}
