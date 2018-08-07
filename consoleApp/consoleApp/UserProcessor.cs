using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApp
{
    public class UserProcessor
    { 
        private IUserProvider provider;

        public UserProcessor(IUserProvider provider)
        {
            if (provider == null)
                throw new ArgumentNullException(nameof(provider));

            this.provider = provider;
        }

        public int GetNumUsers()
        {
            IEnumerable<IUser> users;

            try
            {
                users = provider.GetUsers();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            if (users == null)
                return 0;

            return users.Count();
        }

        public void UpdateUser(IUser user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            provider.UpdateUser(user);
        }
    }
}
