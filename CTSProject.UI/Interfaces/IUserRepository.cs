using CTSProject.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTSProject.UI.Interfaces
{
    public interface IUserRepository: IRepository<User>
    {
        //IEnumerable<User> IsUserExists(string username);
    }
}
