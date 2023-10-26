using Project.DataAccessLAyer.Concrete;
using Project.DataAccessLAyer.Repositories.Abstracts;
using Project.EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccessLAyer.Repositories.Concretes
{
    public class AppUserRepository : GenericRepository<AppUser>, IAppUserRepository
    {
        public AppUserRepository(Context context) : base(context)
        {
        }
    }
}
