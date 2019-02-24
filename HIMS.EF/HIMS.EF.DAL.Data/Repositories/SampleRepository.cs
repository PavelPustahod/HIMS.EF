using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMS.EF.DAL.Data.Repositories
{
    public class SampleRepository : IRepository<Sample>
    {
        private readonly HIMSDbContext _dbContext;

        public SampleRepository(HIMSDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Sample item)
        {
            _dbContext.Samples.Add(item);
        }

        public void Delete(int id)
        {
            var entity = _dbContext.Samples.Find(id);
            if (entity != null)
            {
                _dbContext.Samples.Remove(entity);
            }
        }

        public IEnumerable<Sample> Find(Func<Sample, bool> predicate)
        {
            return _dbContext.Samples.Where(predicate).ToList();
        }

        public Sample Get(int id)
        {
            return _dbContext.Samples.Find(id);
        }

        public IEnumerable<Sample> GetAll()
        {
            return _dbContext.Samples.ToList();
        }

        public void Update(Sample item)
        {
            _dbContext.Entry(item).State = EntityState.Modified;
        }
    }
}
