namespace CS.Data.Base
{
    public class UnitOfWork<TContext> : IUnitOfWork<TContext>
        where TContext : class, IContext<TContext>, new()
    {
        private readonly IContext<TContext> _context;

        public UnitOfWork()
        {
            _context = new TContext();
        }

        public UnitOfWork(IContext<TContext> context)
        {
            _context = context;
        }
        public int Save()
        {
            return _context.SaveChanges();
        }

        public IContext<TContext> Context => (TContext)_context;

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}