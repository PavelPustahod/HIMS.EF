using HIMS.EF.DAL.Data;
using HIMS.EF.DAL.Data.Interfaces;
using HIMS.EF.DAL.Data.Repositories;
using HIMS.EF.DAL.Identity.Repositories;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMS.BL.Infrastructure
{
    class ServicesModule : NinjectModule
    {
        private string _connectionString;
        private string _identityConnectionString;
        public ServicesModule(string connection, string identityConnection)
        {
            _connectionString = connection;
            _identityConnectionString = identityConnection;
        }

        public override void Load()
        {
            Bind<IUnitOfWork>().To<EFUnitOfWork>().WithConstructorArgument(_connectionString);
            Bind<HIMS.EF.DAL.Identity.Interfaces.IUnitOfWork>().To<IdentityUnitOfWork>().WithConstructorArgument(_identityConnectionString);
            Bind<IProcedureManager>().To<ProcedureManager>().WithConstructorArgument(_connectionString);
        }
    }
}
