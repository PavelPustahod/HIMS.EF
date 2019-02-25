using HIMS.EF.DAL.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMS.EF.DAL.Data.Repositories
{
    class ProcedureManager : IProcedureManager
    {
        private HIMSDbContext _db;

        public ProcedureManager(string connectionString)
        {
            _db = new HIMSDbContext(connectionString);
        }

        public int GetSampleEntriesAmount(bool isAdmin)
        {
            int result = 0;
            //_db.SampleEntriesAmount(isAdmin, ref result);
            return result;
        }
    }
}
