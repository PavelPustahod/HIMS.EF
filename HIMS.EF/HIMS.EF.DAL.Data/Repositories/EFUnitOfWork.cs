using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMS.EF.DAL.Data.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private HIMSDbContext db;
        private SampleRepository _sampleRepository;

        public EFUnitOfWork(string connectionString)
        {
            db = new HIMSDbContext(connectionString);
        }
        public IRepository<Sample> Samples
        {
            get
            {
                if (_sampleRepository == null)
                    _sampleRepository = new SampleRepository(db);
                return _sampleRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
