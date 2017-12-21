using CTSProject.Data;
using CTSProject.Data.Model;
using CTSProject.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTSProject.UI.Repository
{
    class UserRepository: Repository<User>, IUserRepository
    {
        public UserRepository(OnlineShopContext context)
        {
            _context = context;
        }

        public bool IsUserExists(string username)
        {
            return _context.Users.Any(s => s.Login == username);
        }
    }
}
