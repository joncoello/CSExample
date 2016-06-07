namespace CS.Data.Base
{
    public class UnitOfWork<TContext> : IUnitOfWork
        where TContext : IContext, new()
    {
        private readonly IContext _context;

        public UnitOfWork()
        {
            _context = new TContext();
        }

        public UnitOfWork(IContext context)
        {
            _context = context;
        }
        public int Save()
        {
            return _context.SaveChanges();
        }

        public IContext Context => (TContext)_context;

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}