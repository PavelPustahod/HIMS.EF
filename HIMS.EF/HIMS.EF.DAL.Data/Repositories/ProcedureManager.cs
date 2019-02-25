using HIMS.EF.DAL.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMS.EF.DAL.Data.Repositories
{
    public class ProcedureManager : IProcedureManager
    {
        private readonly HIMSDbContext _himsDbContext;

        public ProcedureManager(string connectionString)
        {
            _himsDbContext = new HIMSDbContext(connectionString);
        }

        public int GetSampleEntriesAmount(bool isAdmin)
        {
            ObjectParameter result = new ObjectParameter("result", typeof(int));
            int res = 0;
            //res = _himsDbContext.SampleEntriesAmount(isAdmin, ref result);
            return res;
        }
    }
}
