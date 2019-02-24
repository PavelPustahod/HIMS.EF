using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMS.EF.DAL.Identity.Models
{
    public class UserSecurityManager : UserManager<ApplicationUser>
    {
        public UserSecurityManager(IUserStore<ApplicationUser> store) : base(store)
        {
        }
    }
}
