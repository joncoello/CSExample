using System.Data.Entity;
using System.Runtime.CompilerServices;


namespace CS.Data.Base
{
    public class BaseContext<TContext>
   : DbContext where TContext : DbContext
    {
        
        static BaseContext()
        {
            Database.SetInitializer<TContext>(null);
        }
        protected BaseContext()
          : base("name=ClientContext")
        { }
    }
}
