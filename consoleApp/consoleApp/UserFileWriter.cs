using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApp
{
    public class UserFileWriter
    {
        public void WriteUsers(IEnumerable<User> users, string filePath)
        {
            using (var sw = new StreamWriter(filePath))
            {
                foreach(var user in users)
                {
                    sw.WriteLine(user.FirstName + " " + user.LastName);
                }
            }
        }
    }
}
