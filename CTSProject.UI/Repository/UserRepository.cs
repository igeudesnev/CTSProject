using CTSProject.Data.Model.ToDb;
using CTSProject.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTSProject.UI.Repository
{
    class UserRepository: Repository<User>, IUserRepository<User>
    {
    }
}
