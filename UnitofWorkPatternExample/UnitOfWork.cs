using System;

namespace UnitofWorkPatternExample
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly MyDatabaseContext _context;
        private IGenericRepository<Model> _modelRepository;
        private bool disposed = false;

        public UnitOfWork(MyDatabaseContext context)
        {
            _context = context;
        }

        public IGenericRepository<Model> ModelRepository
        {
            get { return _modelRepository ?? (_modelRepository = new GenericRepository<Model>(_context)); }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
