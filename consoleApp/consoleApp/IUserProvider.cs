using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApp
{
    public interface IUserProvider
    {
        IEnumerable<IUser> GetUsers();
        void UpdateUser(IUser user);
    }
 }
