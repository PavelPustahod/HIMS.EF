using HIMS.EF.DAL.Data;
using HIMS.EF.DAL.Identity.Interfaces;
using HIMS.EF.DAL.Identity.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMS.EF.DAL.Identity.Repositories
{
    public class IdentityUnitOfWork : Interfaces.IUnitOfWork
    {
        private readonly IdentityContext _db;

        private readonly ApplicationRoleManager _applicationManager;
        private readonly UserSecurityManager _userSecurityManager;

        public IdentityUnitOfWork(string connectionString)
        {
            _db = new IdentityContext(connectionString);
            _applicationManager = new ApplicationRoleManager(new RoleStore<ApplicationRole>(_db));
            _userSecurityManager = new UserSecurityManager(new UserStore<ApplicationUser>(_db));
        }

        public ApplicationRoleManager ApplicationRoleManager => _applicationManager;

        public UserSecurityManager UserSecurityManager => _userSecurityManager;

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync().ConfigureAwait(false);
        }

        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                    _applicationManager.Dispose();
                    _userSecurityManager.Dispose();
                }
            }
            this.disposed = true;
        }
    }
}
